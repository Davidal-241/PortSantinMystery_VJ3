using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;



public class ElevatorLogical : MonoBehaviour
{
    [SerializeField] string[] _sceneNames;

    [SerializeField] GameObject _buttonsSelector;

    [SerializeField] GameObject[] _buttons;


    private int _currentButtonIndex;

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

        _controls.Player.Disable();
        _currentScene = SceneManager.GetActiveScene();

        
            if (_currentScene.name == _sceneNames[0])
            {
                _currentButtonIndex = 0;

            }

            if (_currentScene.name == _sceneNames[1])
            {
                _currentButtonIndex = 1;
            }

            if (_currentScene.name == _sceneNames[2])
            {
                _currentButtonIndex = 2;
            }

            UpdateSelectorPosition();


    }

    private void UpdateSelectorPosition()
    {

        _buttonsSelector.transform.parent = _buttons[_currentButtonIndex].transform;
        _buttonsSelector.transform.localPosition = Vector3.zero;


        if(string.Compare(_sceneNames[_currentButtonIndex], _currentScene.name) != 0)
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
            _currentButtonIndex = (_currentButtonIndex + 1 + _buttons.Length) % _buttons.Length;
            UpdateSelectorPosition();
    }
    private void ScrollDownByInterface(InputAction.CallbackContext context)
    {
            _currentButtonIndex = (_currentButtonIndex - 1 + _buttons.Length) % _buttons.Length;
            UpdateSelectorPosition();
    }
    private void UseTheButton(InputAction.CallbackContext context)
    {
        if (_canUseTheButton)
        {
            EventManager.ElevatorSound.Invoke();
            ChangeScene();
        }
    }


    private void ChangeScene()
    {
        EventManager._ChangeScene.Invoke(_sceneNames[_currentButtonIndex]);
        _controls.Inventory.Disable();
    }
}

