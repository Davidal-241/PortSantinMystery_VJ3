using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuPauseMovement : MonoBehaviour
{
    [SerializeField] GameObject _objectToActive;
    bool _isTheMainMenu = false;
    GameObject[] _slots;
    [SerializeField] GameObject[] _differentsMenu;
    [SerializeField] GameObject[] _buttonsInMenu;
    [SerializeField] GameObject _menuSelector;

    LogicVolumen _logicV;
    LogicaFullScree _logicFullScreen;

    int _currentButtonsIndex;
    int _currentMenuIndex;

    private int _allMenus;
    private int _allButtons;

    private InputAction OpenClose;
    [SerializeField] UserActions _controls;

    bool _canChangeSliderValue = false;
    private void Awake()
    {
        _objectToActive = GameObject.Find("//ObjectToActive/Disabled/");
        _logicV = FindObjectOfType<LogicVolumen>();
        _logicFullScreen = FindObjectOfType<LogicaFullScree>();
        _controls = new UserActions();
    }

    private void OnEnable()
    {
        OpenClose = _controls.MenuPause.OpenClose;
        OpenClose.Enable();
        OpenClose.performed += UseMenu;
    }
    private void OnDisable()
    {
        OpenClose.Disable();
    }

    private void Start()
    {
        _allMenus = _objectToActive.transform.childCount;

        _differentsMenu = new GameObject[_allMenus];

        for (int i = 0; i < _allMenus; i++)
        {
            _differentsMenu[i] = _objectToActive.transform.GetChild(i).gameObject;
            _slots[i] = _differentsMenu[i].transform.GetChild(3).gameObject;
            _buttonsInMenu[i] = _slots[i].transform.GetChild(i).gameObject;
        }

        if(_objectToActive != null)
        {
            _objectToActive.SetActive(false);
        }
    }

    private void Update()
    {
        _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;

    }

    private void UseMenu(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isMenuPauseActive)
        {
            _objectToActive.SetActive(true);
            GlobalBools._isInventoryActive = false;
            GlobalBools._isMenuPauseActive = true;

            GlobalBools._playerCanMove = true;

            _currentMenuIndex = 0;
            _currentButtonsIndex = 0;
            _differentsMenu[_currentMenuIndex].SetActive(true);
        }
        else
        {
            _objectToActive.SetActive(false);
            GlobalBools._isMenuPauseActive = false;

            GlobalBools._playerCanMove = false;

            _differentsMenu[_currentMenuIndex].SetActive(false);

        }
    }

    private void ScrollUpMenuPause(InputAction.CallbackContext context)
    {
        if (GlobalBools._isMenuPauseActive)
        {
            if (!_canChangeSliderValue)
            {
                _currentButtonsIndex = (_currentButtonsIndex + 1 + _buttonsInMenu.Length) % _buttonsInMenu.Length;
                _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;
            }
        }
       
    }
    private void ScrollDownMenuPause(InputAction.CallbackContext context)
    {
        if (GlobalBools._isMenuPauseActive)
        {
            if (!_canChangeSliderValue)
            {

                _currentButtonsIndex = (_currentButtonsIndex - 1 + _buttonsInMenu.Length) % _buttonsInMenu.Length;
                _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;
            }

        }
    }
    private void UseButtons(InputAction.CallbackContext context)
    {
        if(_differentsMenu[_currentMenuIndex] = _differentsMenu[0])
        {
            if(_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[0])
            {
                _differentsMenu[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 1;
                _differentsMenu[_currentMenuIndex].SetActive(true);
                _currentButtonsIndex = 0;
                _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;
            }
        }

        if(_differentsMenu[_currentMenuIndex] = _differentsMenu[0])
        {
            if(_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[1])
            {
                EventManager._GoToMainMenu.Invoke();
            }
        }

        if(_differentsMenu[_currentMenuIndex] = _differentsMenu[1])
        {
            if (_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[0])
            {
                _differentsMenu[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 2;
                _differentsMenu[_currentMenuIndex].SetActive(true);
                _currentButtonsIndex = 0;
                _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;
            }
        }
        
        if(_differentsMenu[_currentMenuIndex] = _differentsMenu[1])
        {
            if (_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[1])
            {
                bool _isFull = _logicFullScreen._toggle.isOn;

                if (!_logicFullScreen._toggle.isOn)
                {
                    _isFull = true;

                    EventManager._FullScreen.Invoke(_isFull);
                }
                else
                {
                    _isFull = false;

                    EventManager._FullScreen.Invoke(_isFull);
                }
            }
        }

        if (_differentsMenu[_currentMenuIndex] = _differentsMenu[1])
        {
            if (_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[2])
            {
                _differentsMenu[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 0;
                _differentsMenu[_currentMenuIndex].SetActive(true);
                _currentButtonsIndex = 0;
                _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;
            }
        }

        if(_differentsMenu[_currentMenuIndex] = _differentsMenu[2])
        {
            if (_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[0])
            {
                _canChangeSliderValue = true;
            }
            else
            {
                _canChangeSliderValue = false;
            }
        }

        if (_differentsMenu[_currentMenuIndex] = _differentsMenu[2])
        {
            if (_buttonsInMenu[_currentButtonsIndex] = _buttonsInMenu[1])
            {
                _differentsMenu[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 1;
                _differentsMenu[_currentMenuIndex].SetActive(true);
                _currentButtonsIndex = 0;
                _menuSelector.transform.position = _buttonsInMenu[_currentButtonsIndex].transform.position;
            }
        }
    }

    private void SliderVolumenMore(InputAction.CallbackContext context)
    {
        if (_canChangeSliderValue)
        {
            float _value = _logicV._sliderValue;

            _value += 0.1f;

            EventManager._VolumenValue.Invoke(_value);
        }
    }

    private void SliderVolumenLess(InputAction.CallbackContext context)
    {
        if (_canChangeSliderValue)
        {
            float _value = _logicV._sliderValue;

            _value -= 0.1f;

            EventManager._VolumenValue.Invoke(_value);
        }
    }
}
