using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;



public class ElevatorLogical : MonoBehaviour, IInteractable
{
    [SerializeField] string[] _nameScene;
    [SerializeField] GameObject _elevatorUI;
    bool _isElevatorUIActive = false;

    [SerializeField] GameObject _buttonsSelector;

    [SerializeField] GameObject[] _buttons;
    [SerializeField] GameObject[] _offImage;

    private int _currentButtonsIndex;

    public Conversation _cesarsCurrentDialogue;

    [SerializeField] int[] _indexScene;

    private void Awake()
    {
        _elevatorUI = GameObject.Find("ElevatorCanvas");
    }

    private void Start()
    {
        if (_elevatorUI != null)
        {
            _elevatorUI.SetActive(false);
        }
    }

    public void Interact()
    {
        UseElevator();
        UIElevator();
    }

    private void UseElevator()
    {
        Scene _currentScene;

        GlobalBools._isInReception = false;
        GlobalBools._isInFirstFloor = false;
        GlobalBools._isInBasement = false;

        for (int i = 0; i < _offImage.Length; i++)
        {
            _offImage[i].SetActive(false);
        }

        ProgressCheck._youTryUseElevator = true;
        _currentScene = SceneManager.GetActiveScene();

        if (ProgressCheck._canUseElevator)
        {
            if (_currentScene.name == _nameScene[0])
            {
                GlobalBools._isInReception = true;
                _offImage[0].SetActive(true);
                _buttons[0].SetActive(false);
                _currentButtonsIndex = 0;

            }

            if (_currentScene.name == _nameScene[1])
            {
                GlobalBools._isInFirstFloor = true;
                _offImage[1].SetActive(true);
                _buttons[1].SetActive(false);
                _currentButtonsIndex = 1;
            }

            if (_currentScene.name == _nameScene[2])
            {
                GlobalBools._isInBasement = true;
                _offImage[2].SetActive(true);
                _buttons[2].SetActive(false);
                _currentButtonsIndex = 2;
            }
        }

        _buttonsSelector.transform.position = _buttons[_currentButtonsIndex].transform.position;

        
    }


    private void UIElevator()
    {
        if (!_elevatorUI.activeSelf)
        {
            _elevatorUI.SetActive(true);
            _isElevatorUIActive = true;
        }
        else
        {
            _elevatorUI.SetActive(false);
            _isElevatorUIActive = false;
        }
    }

    private void ScrollUpByInterface()
    {
        if (_isElevatorUIActive)
        {
            _currentButtonsIndex = (_currentButtonsIndex + 1 + _buttons.Length) % _buttons.Length;
            _buttonsSelector.transform.position = _buttons[_currentButtonsIndex].transform.position;
        }
    }
    private void ScrollDownByInterface()
    {
        if (_isElevatorUIActive)
        {
            _currentButtonsIndex = (_currentButtonsIndex - 1 + _buttons.Length) % _buttons.Length;
            _buttonsSelector.transform.position = _buttons[_currentButtonsIndex].transform.position;
        }
    }
    private void UseTheButton()
    {
        if (_isElevatorUIActive)
        {
           
            CheckIfYouCanUseTheElevator();

        }
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
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {

                    ChangeScene();

                }

                if (_buttons[_currentButtonsIndex] = _buttons[2])
                {
                    if (!ProgressCheck._canUseElevatorToGoDown && GlobalBools._hasAlreadyTalkedToJorge)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_02");
                        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                    }
                    else
                    {
                        ChangeScene();
                    }
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
                    ChangeScene();
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
                        ChangeScene();
                    }
                }


                if (GlobalBools._isInReception)
                {
                    if (!GlobalBools._hasAlreadyTalkedToCenturion)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_06");
                        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                    }
                    else
                    {
                        ChangeScene();
                    }
                }

            }

            if (ProgressCheck._areWeInTheStage6)
            {
                if (!GlobalBools._hasAlreadyTalkedToCenturion)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_07");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    ChangeScene();
                }
            }
        }


    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(_indexScene[_currentButtonsIndex]);
    }
}

