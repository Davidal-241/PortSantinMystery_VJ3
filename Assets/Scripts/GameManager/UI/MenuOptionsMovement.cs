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

        

        _controls.OptionsMenu.Submit.performed += UseButtons;
        _controls.OptionsMenu.NavigateUp.performed += ScrollUpMenuPause;
        _controls.OptionsMenu.NavigateDown.performed += ScrollDownMenuPause;
        _controls.OptionsMenu.NavigateLeft.performed += SliderVolumenLess;
        _controls.OptionsMenu.NavigateRight.performed += SliderVolumenMore;
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
                EventManager.ButtonSound.Invoke();
                UpdateSelectorPosition();
            }

            else if(_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][1])
            {
                EventManager._GoToMainMenu.Invoke();
                EventManager.ButtonSound.Invoke();
            }
        } 

        else if(_menus[_currentMenuIndex] == _menus[1])
        {
            if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][0])
            {
                _canChangeSliderValue = !_canChangeSliderValue;
                EventManager.ButtonSound.Invoke();
            }
           

            else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][1])
            {
                bool _isFull = _logicFullScreen._toggle.isOn;

                if (!_isFull)
                {
                    _isFull = true;
                    EventManager._FullScreen.Invoke(_isFull);
                    EventManager.ButtonSound.Invoke();
                }
                else
                {
                    _isFull = false;
                    EventManager._FullScreen.Invoke(_isFull);
                    EventManager.ButtonSound.Invoke();
                }
            }
            else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][2])
            {
                _menus[_currentMenuIndex].SetActive(false);
                _currentMenuIndex = 0;
                _menus[_currentMenuIndex].SetActive(true);
                _currentButtonIndex = 0;
                EventManager.ButtonSound.Invoke();
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


        _menuSelector.transform.parent = _buttonsInMenu[_currentMenuIndex][_currentButtonIndex].transform;
        _menuSelector.transform.localPosition = Vector3.zero;
        }
    }
}
