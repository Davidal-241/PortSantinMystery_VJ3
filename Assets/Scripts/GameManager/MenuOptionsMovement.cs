using UnityEngine;
using UnityEngine.InputSystem;

public class MenuOptionsMovement : MonoBehaviour
{
    [SerializeField] GameObject _viewManager;


    [SerializeField] GameObject[] _menus;
    [SerializeField] GameObject[][] _buttonsInMenu;
    [SerializeField] GameObject _menuSelector;
    [SerializeField] GameObject _allSlot;

    LogicVolumen _logicV;
    LogicaFullScree _logicFullScreen;

    int _currentButtonIndex;
    [SerializeField] int _currentMenuIndex;

    private int _menuCount;

    private InputAction OpenClose;
    private InputAction _Up;
    private InputAction _Down;
    private InputAction _Use;
    private InputAction _Left;
    private InputAction _Right;
    [SerializeField] UserActions _controls;

    bool _canChangeSliderValue = false;
    private void Awake()
    {
        
        _logicV = FindObjectOfType<LogicVolumen>();
        _logicFullScreen = FindObjectOfType<LogicaFullScree>();

        EventManager._InputSet.AddListener(InputSet);
    }

    void InputSet(UserActions input)
    {
        _controls = input;

        _controls.UserMenu.OpenClose.performed += UseMenu;
        _controls.UI.Submit.performed += UseButtons;
        _controls.UI.NavigateUp.performed += ScrollUpMenuPause;
        _controls.UI.NavigateDown.performed += ScrollDownMenuPause;
        _controls.UI.NavigateLeft.performed += SliderVolumenLess;
        _controls.UI.NavigateRight.performed += SliderVolumenMore;
    }

 

    private void Start()
    {
        _menuCount = _allSlot.transform.childCount;

        _menus = new GameObject[_menuCount];
        _buttonsInMenu = new GameObject[_menuCount][];

        for (int i = 0; i < _menuCount; i++)
        {
            _menus[i] = _allSlot.transform.GetChild(i).gameObject;
            
            _buttonsInMenu[i] = new GameObject[_menus[i].transform.childCount];
            for (int j = 0; j < _menus[i].transform.childCount; j++)
                _buttonsInMenu[i][j] = _menus[i].transform.GetChild(j).gameObject;
            
            _menus[i].SetActive(false);
        }

        
      
        _viewManager.SetActive(false);
    }



    private void UseMenu(InputAction.CallbackContext context)
    {
        if (!GameManager._isMenuPauseActive && !GameManager._isTalking)
        {
            _viewManager.SetActive(true);
            GameManager._isInventoryActive = false;
            GameManager._isMenuPauseActive = true;

            GameManager._playerCanMove = true;


            _currentMenuIndex = 0;
            _currentButtonIndex = 0;
            _menus[_currentMenuIndex].SetActive(true);
            UpdateSelectorPosition();
        }
        else if(GameManager._isMenuPauseActive && !GameManager._isTalking)
        {
            _viewManager.SetActive(false);
            GameManager._isMenuPauseActive = false;

            GameManager._playerCanMove = false;

            _menus[_currentMenuIndex].SetActive(false);

        }
    }

    private void ScrollDownMenuPause(InputAction.CallbackContext context)
    {

        if (GameManager._isMenuPauseActive)
        {
            if (!_canChangeSliderValue)
            {
                _currentButtonIndex = (_currentButtonIndex + 1 + _buttonsInMenu[_currentMenuIndex].Length) % _buttonsInMenu[_currentMenuIndex].Length;
                UpdateSelectorPosition();
            }
        }
       
    }
    private void ScrollUpMenuPause(InputAction.CallbackContext context)
    {

        if (GameManager._isMenuPauseActive)
        {
            if (!_canChangeSliderValue)
            {

                _currentButtonIndex = (_currentButtonIndex - 1 + _buttonsInMenu[_currentMenuIndex].Length) % _buttonsInMenu[_currentMenuIndex].Length;
                UpdateSelectorPosition();
            }

        }
    }
    private void UseButtons(InputAction.CallbackContext context)
    {
        if (_menus[_currentMenuIndex] == _menus[0])
        {
            if(_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][0])
            {
                _menus[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 1;
                _menus[_currentMenuIndex].SetActive(true);
                _currentButtonIndex = 0;
                UpdateSelectorPosition();
            }

            else if(_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][1])
            {
                EventManager._GoToMainMenu.Invoke();
            }
        } 

        else if(_menus[_currentMenuIndex] == _menus[1])
        {
            if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][0])
            {
                _canChangeSliderValue = !_canChangeSliderValue;
            }
           

            else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][1])
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
            else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][2])
            {
                _menus[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 0;
                _menus[_currentMenuIndex].SetActive(true);
                _currentButtonIndex = 0;
                UpdateSelectorPosition();
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


    private void UpdateSelectorPosition()
    {
        if (GameManager._isMenuPauseActive)
        {

        print(_currentMenuIndex + " " + _currentButtonIndex);

        _menuSelector.transform.parent = _buttonsInMenu[_currentMenuIndex][_currentButtonIndex].transform;
        _menuSelector.transform.localPosition = Vector3.zero;
        }
    }
}
