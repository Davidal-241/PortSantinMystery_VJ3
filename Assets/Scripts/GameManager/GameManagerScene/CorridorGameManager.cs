using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorGameManager : GameManager
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

            _player.transform.rotation =  Quaternion.Euler(0, 90, 0);
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

        print("NextRequestCondition: " + _currenStoryParts + " - " + _currentStagesStoryParts + " - " + _currentQuest);

        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
            print("Instantiate Luna");
                Instantiate(_lunaPrefab, _LunaSpawnPoint.position, _LunaSpawnPoint.rotation);
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
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                if (_currentQuest == FinishedQuest.OUTSIDETHEROOM)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    UIElevator();
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                if (_currentQuest == FinishedQuest.SPOKELUNA)
                {
                    if (!LunaDialogueManager._hasAlreadyTalkedToLuna)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_05");
                        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                    }

                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {
                if (_currentQuest == FinishedQuest.OUTSIDECENTURIONROOM)
                {
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
