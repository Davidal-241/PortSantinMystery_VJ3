using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenturionCorridorGameManager : GameManager
{
    [SerializeField] Transform comingFromElevatorToCenturionHallTransform;
    #region"Reference UI"
    GameObject _elevatorUI;
    #endregion

    protected override void Start()
    {

        if (string.Compare(_previousSceneName, "Vestibulo") == 0)
        {
            _player.transform.position = comingFromElevatorToCenturionHallTransform.position;

            _player.transform.rotation = comingFromElevatorToCenturionHallTransform.rotation;
        }
        if (string.Compare(_previousSceneName, "Pasillo") == 0)
        {
            _player.transform.position = comingFromElevatorToCenturionHallTransform.position;

            _player.transform.rotation = comingFromElevatorToCenturionHallTransform.rotation;
        }
        base.Start();

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
