using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    UserActions _controls;
    GameObject _elevatorUI;

    public Conversation _cesarsCurrentDialogue;


    private void Start()
    {
        _controls = new UserActions();
        _controls.Enable();
        _controls.Player.Enable();
        _controls.UI.Disable();
        _controls.UserMenu.Disable();
        _controls.Conversation.Disable();

        EventManager._InputSet.Invoke(_controls);
        print(name + " invokes");

        _elevatorUI = GameObject.Find(" ElevatorPanel");

        _elevatorUI.SetActive(false);


        EventManager._GoToMainMenu.AddListener(GoMenuPrincipalMain);
        EventManager._CheckConveElevator.AddListener(CheckIfYouCanUseTheElevator);
        EventManager._ChangeScene.AddListener(ChangeScene);
    }
    public void GoMenuPrincipalMain()
    {
        SceneManager.LoadScene(0);
    }

    private void CheckIfYouCanUseTheElevator()
    {
        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage2)
            {
                if (!GlobalBools._hasAlreadyTalkedToJorge)
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

            if (ProgressCheck._areWeInTheStage3)
            {
                if (!ProgressCheck._didYouLeaveTheSuitcase)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    UIElevator();
                }
            }

            if (ProgressCheck._areWeInTheStage5)
            {
                if (GlobalBools._isInFirstFloor)
                {
                    if (!GlobalBools._hasAlreadyTalkedToLuna)
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


        }
    }

    private void UIElevator()
    {
        if (!_elevatorUI.activeSelf)
        {
            _elevatorUI.SetActive(true);
            GlobalBools._isElevatorUIActive = true;
            EventManager._UseElevator.Invoke();
        }
        else
        {
            _elevatorUI.SetActive(false);
            GlobalBools._isElevatorUIActive = false;
        }
    }

    private void ChangeScene(int _indexSceneUseButton)
    {
        SceneManager.LoadScene(_indexSceneUseButton);
    }

}
