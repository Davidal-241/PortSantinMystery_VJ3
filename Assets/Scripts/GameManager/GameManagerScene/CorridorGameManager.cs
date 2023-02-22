using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallGameManager : GameManager
{
    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] Transform _LunaSpawnPoint;

    [SerializeField] Transform comingFromElevatorToHallTransform;
    [SerializeField] Transform comingFromInsideCesarRoomTransform;

    #region"Reference UI"
    GameObject _elevatorUI;
    #endregion

    protected override void Start()
    {
        if (string.Compare(_previousSceneName, "Habitacion_Cesar") == 0)
        {
            _player.transform.position = comingFromInsideCesarRoomTransform.position;

            _player.transform.rotation = comingFromInsideCesarRoomTransform.rotation;
        }
        else if (string.Compare(_previousSceneName, "Pasillo Centurion") == 0)
        {
            _player.transform.position = comingFromElevatorToHallTransform.position;
            _player.transform.rotation = comingFromElevatorToHallTransform.rotation;

        }
        else if (string.Compare(_previousSceneName, "Vestibulo") == 0)
        {
            _player.transform.position = comingFromElevatorToHallTransform.position;


            _player.transform.rotation = comingFromElevatorToHallTransform.rotation;
        }

        base.Start();

        if (_currentQuest == FinishedQuest.SPOKELUNA)
        {
            if (_currenStoryParts == StoryParts.FIRST_PART)
            {
                if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
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
        //Comprueba si Cesar puede usar el ascensor o debe decir un dialogo//
        UIElevator();

        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if (!JorgeDialogueManager._hasAlreadyTalkedToJorge)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                    print(_cesarsCurrentDialogue);
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
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
