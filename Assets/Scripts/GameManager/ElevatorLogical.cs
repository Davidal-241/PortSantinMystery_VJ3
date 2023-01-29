using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ElevatorLogical : MonoBehaviour, IInteractable
{
    [SerializeField] string[] _nameScene;
    [SerializeField] GameObject _elevatorUI;
    bool _isElevatorUIActive = false;


    [SerializeField] GameObject _buttonsSelector;

    [SerializeField] GameObject[] _buttons;

    private int _currentButtonsIndex;

    [SerializeField] Color _colorOn;
    [SerializeField] Color _colorOff;


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


        ProgressCheck._youTryUseElevator = true;
        _currentScene = SceneManager.GetActiveScene();

        if (ProgressCheck._canUseElevator)
        {
            if (_currentScene.name == _nameScene[0])
            {
                GlobalBools._isInReception = true;
                _currentButtonsIndex = 0;

            }

            if (_currentScene.name == _nameScene[1])
            {
                GlobalBools._isInFirstFloor = true;
                _currentButtonsIndex = 1;
            }

            if (_currentScene.name == _nameScene[2])
            {
                GlobalBools._isInBasement = true;
                _currentButtonsIndex = 2;
            }
        }

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

        }
    }
    private void ScrollDownByInterface()
    {
        if (_isElevatorUIActive)
        {

        }
    }
    private void UseTheButton()
    {
        if (_isElevatorUIActive)
        {

        }
    }


}

