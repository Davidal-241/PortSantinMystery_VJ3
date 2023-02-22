using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionGameManager : GameManager
{
    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] Transform _LunaSpawnPoint;
    [SerializeField] Transform comingFromElevatorTransform;
    [SerializeField] Transform comingFromOutsideTransform;

    #region"Reference UI"
    GameObject _elevatorUI;
    #endregion



    protected override void Start()
    {
        if (
                string.Compare(_previousSceneName, "Pasillo") == 0
                ||
                string.Compare(_previousSceneName, "Pasillo Centurion") == 0
            )
        {
            _player.transform.position = comingFromElevatorTransform.position;

            _player.transform.rotation = comingFromElevatorTransform.rotation;


        }
        else if (string.Compare(_previousSceneName, "Exterior") == 0)
        {
            _player.transform.position = comingFromOutsideTransform.position;

            _player.transform.rotation = comingFromOutsideTransform.rotation;
        }

        base.Start();

        if (_currentQuest == FinishedQuest.SPEAKWITHLUNAINRECEPTION)
        {
            if (_currenStoryParts == StoryParts.FIRST_PART)
            {
                if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
                {

                    Instantiate(_lunaPrefab, _LunaSpawnPoint);
                }
            }
        }

        EventManager._CheckConveElevator.AddListener(CheckIfYouCanUseTheElevator);


        #region"UI"
        //Interfaz de ascensor//
        _elevatorUI = GameObject.Find("ElevatorPanel");

        _elevatorUI.SetActive(false);

        #endregion
    }



    #region"ElevatorLogical"
    private void CheckIfYouCanUseTheElevator()
    {
        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                print("_hasAlreadyTalkedToJorge: " + JorgeDialogueManager._hasAlreadyTalkedToJorge);

                if (!JorgeDialogueManager._hasAlreadyTalkedToJorge)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                    print(_cesarsCurrentDialogue);
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }

            }

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                print("_hasAlreadyTalkedToJorge: " + JorgeDialogueManager._hasAlreadyTalkedToJorge);

                if (JorgeDialogueManager._hasAlreadyTalkedToJorge)
                {
                    print("a");
                    UIElevator();
                }

            }

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                if (_currentQuest != FinishedQuest.LEAVESUITCASE)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    print("b");
                    UIElevator();
                }
            }

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                if (_currentQuest == FinishedQuest.OUTSIDETHEROOM)
                {
                    if (!LunaDialogueManager._hasAlreadyTalkedToLuna)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_05");
                        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                    }
                    else
                    {
                        print("c");
                        UIElevator();
                    }
                }

            }

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {
                if (_currentQuest == FinishedQuest.OUTSIDECENTURIONROOM)
                {
                    if (!_hasAlreadyInteractueWithCenturionDoor)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_07");
                        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                    }
                    else
                    {
                        print("d");
                        UIElevator();
                    }
                }

            }

        }
    }
    #endregion

    #region"UIElevator"
    private void UIElevator()
    {
        print("___");


        //Activa o Desactiva la interfaz del ascensor dependiendo de su estado//
        if (!_elevatorUI.activeSelf)
        {
            _elevatorUI.SetActive(true);
            isElevatorUIActive = true;
            EventManager._UseElevator.Invoke();
            EventManager.UIOn.Invoke();
        }
        else
        {
            _elevatorUI.SetActive(false);
            isElevatorUIActive = false;
            EventManager.UIOff.Invoke();
        }
    }
    #endregion

}
