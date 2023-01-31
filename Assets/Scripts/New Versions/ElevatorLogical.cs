using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;



public class ElevatorLogical : MonoBehaviour, IInteractable
{
    [SerializeField] int[] _nameScene;
    [SerializeField] GameObject _elevatorUI;
    bool _isElevatorUIActive = false;

    [SerializeField] GameObject _buttonsSelector;

    [SerializeField] GameObject[] _buttons;
    [SerializeField] GameObject[] _offImage;

    private int _currentButtonsIndex;

    public Conversation _cesarsCurrentDialogue;

    [SerializeField] int[] _indexScene;

    UserActions _controls;
    InputAction _upScroll, _downScroll, _useButton;

    private void Awake()
    {
        _elevatorUI = GameObject.Find("ElevatorCanvas");
        _controls = new UserActions();
    }

    private void OnEnable()
    {
        _upScroll = _controls.UI.NavigateUp;
        _upScroll.Enable();
        _upScroll.performed += ScrollUpByInterface;

        _downScroll = _controls.UI.NavigateDown;
        _downScroll.Enable();
        _downScroll.performed += ScrollDownByInterface;

        _useButton = _controls.UI.Submit;
        _useButton.Enable();
        _useButton.performed += UseTheButton;
    }

    private void OnDisable()
    {
        _upScroll.Disable();
        _downScroll.Disable();
        _useButton.Disable();
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
            if (_currentScene.buildIndex == _nameScene[0])
            {
                GlobalBools._isInReception = true;
                _offImage[0].SetActive(true);
                _buttons[0].SetActive(false);
                _currentButtonsIndex = 0;

            }

            if (_currentScene.buildIndex == _nameScene[1])
            {
                GlobalBools._isInFirstFloor = true;
                _offImage[1].SetActive(true);
                _buttons[1].SetActive(false);
                _currentButtonsIndex = 1;
            }

            //if (_currentScene.buildIndex == _nameScene[2])
            //{
            //    GlobalBools._isInBasement = true;
            //    _offImage[2].SetActive(true);
            //    _buttons[2].SetActive(false);
            //    _currentButtonsIndex = 2;
            //}
        }

        UpdateSelectorPosition();


    }


    private void UpdateSelectorPosition()
    {
        _buttonsSelector.transform.parent = _buttons[_currentButtonsIndex].transform;
        _buttonsSelector.transform.localPosition = Vector3.zero;
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

    private void ScrollUpByInterface(InputAction.CallbackContext context)
    {
        if (_isElevatorUIActive)
        {
            _currentButtonsIndex = (_currentButtonsIndex + 1 + _buttons.Length) % _buttons.Length;
            UpdateSelectorPosition();
        }
    }
    private void ScrollDownByInterface(InputAction.CallbackContext context)
    {
        if (_isElevatorUIActive)
        {
            _currentButtonsIndex = (_currentButtonsIndex - 1 + _buttons.Length) % _buttons.Length;
            UpdateSelectorPosition();
        }
    }
    private void UseTheButton(InputAction.CallbackContext context)
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

            }
        }


    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(_indexScene[_currentButtonsIndex]);
    }
}

