using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;



public class ElevatorLogical : MonoBehaviour
{
    [SerializeField] int[] _indexScene;

    [SerializeField] GameObject _buttonsSelector;

    [SerializeField] GameObject[] _buttons;


    private int _currentButtonsIndex;

    Scene _currentScene;

    UserActions _controls;

    bool _canUseTheButton = false;

    private void Awake()
    {
        EventManager._InputSet.AddListener(InputSet);
        EventManager._UseElevator.AddListener(UseElevator);

    }

    void InputSet(UserActions input)
    {
        _controls = input;

        _controls.Inventory.Submit.performed += UseTheButton;
        _controls.Inventory.NavigateUp.performed += ScrollUpByInterface;
        _controls.Inventory.NavigateDown.performed += ScrollDownByInterface;
    }

    private void UseElevator()
    {
   
        _currentScene = SceneManager.GetActiveScene();

        
            if (_currentScene.buildIndex == _indexScene[0])
            {
                _currentButtonsIndex = 0;

            }

            if (_currentScene.buildIndex == _indexScene[1])
            {
                _currentButtonsIndex = 1;
            }

            if (_currentScene.buildIndex == _indexScene[2])
            {
                _currentButtonsIndex = 2;
            }

            UpdateSelectorPosition();


    }

    private void UpdateSelectorPosition()
    {

        _buttonsSelector.transform.parent = _buttons[_currentButtonsIndex].transform;
        _buttonsSelector.transform.localPosition = Vector3.zero;

        if(_currentButtonsIndex != _currentScene.buildIndex)
        {
            _canUseTheButton = true;
        }
        else
        {
            _canUseTheButton = false;
        }

        //_canUseTheButton = _currentButtonsIndex != _currentScene.buildIndex;
    }


    private void ScrollUpByInterface(InputAction.CallbackContext context)
    {
            _currentButtonsIndex = (_currentButtonsIndex + 1 + _buttons.Length) % _buttons.Length;
            UpdateSelectorPosition();
    }
    private void ScrollDownByInterface(InputAction.CallbackContext context)
    {
            _currentButtonsIndex = (_currentButtonsIndex - 1 + _buttons.Length) % _buttons.Length;
            UpdateSelectorPosition();
    }
    private void UseTheButton(InputAction.CallbackContext context)
    {
        if (_canUseTheButton)
        {
            ChangeScene();
        }
    }


    private void ChangeScene()
    {
        EventManager._ChangeScene.Invoke(_indexScene[_currentButtonsIndex]);
    }
}

