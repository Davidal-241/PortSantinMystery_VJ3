using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionGameManager : GameManager
{
    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] GameObject _lunaInScene;
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
                if (_currentStagesStoryParts == StagesStoryParts.STAGE_8)
                {

                    GameObject LunaInsta = Instantiate(_lunaPrefab, _LunaSpawnPoint);
                    _lunaInScene = LunaInsta;
                    _lunaInScene.GetComponent<BoxCollider>().enabled = false;
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

                if (!JorgeDialogueManager._hasAlreadyTalkedToJorge)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                    print(_cesarsCurrentDialogue);
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }

            }

           else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {

                if (JorgeDialogueManager._hasAlreadyTalkedToJorge)
                {
                    UIElevator();
                }

            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
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
            else
            {
                UIElevator();
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
