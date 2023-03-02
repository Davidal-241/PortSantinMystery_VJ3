using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] Button mainMenuDefaultButton;

    [SerializeField] GameObject optionsMenu;
    [SerializeField] Selectable optionsMenuDefaultButton;

    [SerializeField] Animator _fadeInAni;
    bool _startGame = false;


    /*
    [SerializeField] GameObject[] _menus;
    [SerializeField] GameObject[][] _buttonsInMenu;
    [SerializeField] GameObject _menuSelector;
    [SerializeField] GameObject _allSlot;
    */

    LogicVolumen _logicV;

    //LogicaFullScree _logicFullScreen;

    //[SerializeField] int _currentButtonIndex;
    //[SerializeField] int _currentMenuIndex;

    private int _menuCount;

    //[SerializeField] UserActions _controls;

    bool _canChangeSliderValue = false;
    private void Awake()
    {

        //_logicV = FindObjectOfType<LogicVolumen>();
        //_logicFullScreen = FindObjectOfType<LogicaFullScree>();

        //EventManager._InputSet.AddListener(InputSet);
    }

    
    private void Start()
    {
        optionsMenu.SetActive(false);

        //_menuCount = _allSlot.transform.childCount;

        //_menus = new GameObject[_menuCount];
        //_buttonsInMenu = new GameObject[_menuCount][];

        //for (int i = 0; i < _menuCount; i++)
        //{
        //    _menus[i] = _allSlot.transform.GetChild(i).gameObject;

        //    _buttonsInMenu[i] = new GameObject[_menus[i].transform.childCount];
        //    for (int j = 0; j < _menus[i].transform.childCount; j++)
        //    {

        //        _buttonsInMenu[i][j] = _menus[i].transform.GetChild(j).gameObject;
        //        _buttonsInMenu[i][j].SetActive(false);
        //    }
            
        //}

        //for (int i = 0; i < _menuCount; i++)
        //    print(_buttonsInMenu[i].Length);
        //UpdateSelectorPosition();
    }
    
    /*
    void InputSet(UserActions input)
    {
        _controls = input;

        _controls.OptionsMenu.Submit.performed += UseButtons;
        _controls.OptionsMenu.NavigateUp.performed += ScrollUpMenuPause;
        _controls.OptionsMenu.NavigateDown.performed += ScrollDownMenuPause;
        _controls.OptionsMenu.NavigateLeft.performed += SliderVolumenLess;
        _controls.OptionsMenu.NavigateRight.performed += SliderVolumenMore;
    }

    private void ScrollDownMenuPause(InputAction.CallbackContext context)
    {
        print("down");
        if (!_canChangeSliderValue)
        {
            _currentButtonIndex = (_currentButtonIndex + 1 + _buttonsInMenu[_currentMenuIndex].Length) % _buttonsInMenu[_currentMenuIndex].Length;
            UpdateSelectorPosition();
        }
        
    }
    private void ScrollUpMenuPause(InputAction.CallbackContext context)
    {
        print("up");

        if (!_canChangeSliderValue)
        {
            _currentButtonIndex = (_currentButtonIndex - 1 + _buttonsInMenu[_currentMenuIndex].Length) % _buttonsInMenu[_currentMenuIndex].Length;
            UpdateSelectorPosition();
        }
        
    }
    private void UseButtons(InputAction.CallbackContext context)
    {
        //Jugar
        if (_menus[_currentMenuIndex] == _menus[0])
        {
            if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][0])
            {
                SceneManager.LoadScene("Exterior"); //Iniciar juego
            }
        }
        //Opciones
        else if (_menus[_currentMenuIndex] == _menus[1])
        {
            //if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][0])
            //{
            //    _canChangeSliderValue = !_canChangeSliderValue;
            //    EventManager.ButtonSound.Invoke();
            //}


            //else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][1])
            //{
            //    bool _isFull = _logicFullScreen._toggle.isOn;

            //    if (!_isFull)
            //    {
            //        _isFull = true;
            //        EventManager._FullScreen.Invoke(_isFull);
            //        EventManager.ButtonSound.Invoke();
            //    }
            //    else
            //    {
            //        _isFull = false;
            //        EventManager._FullScreen.Invoke(_isFull);
            //        EventManager.ButtonSound.Invoke();
            //    }
            //}
            //else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[1][2])
            //{
            //    _menus[_currentMenuIndex].SetActive(false);
            //    _currentMenuIndex = 0;
            //    _menus[_currentMenuIndex].SetActive(true);
            //    _currentButtonIndex = 0;
            //    EventManager.ButtonSound.Invoke();
            //    UpdateSelectorPosition();
            //}
        }
        //Creditos
        else if (_menus[_currentMenuIndex] == _menus[2])
        {
            if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][0])
            {
                SceneManager.LoadScene("Creditos"); //Iniciar juego
            }
        }
        //Salir
        else if (_menus[_currentMenuIndex] == _menus[2])
        {
            //if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][0])
            //{
            //    _menus[_currentMenuIndex].SetActive(false);
            //    _currentMenuIndex = 1;
            //    _menus[_currentMenuIndex].SetActive(true);
            //    _currentButtonIndex = 0;
            //    EventManager.ButtonSound.Invoke();
            //    UpdateSelectorPosition();
            //}

            //else if (_buttonsInMenu[_currentMenuIndex][_currentButtonIndex] == _buttonsInMenu[0][1])
            //{
            //    Application.Quit();
            //}
        }
    }
    */

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

    /*
    private void UpdateSelectorPosition()
    {
        _buttonsInMenu[_currentMenuIndex][_currentButtonIndex].SetActive(true);
        _menuSelector.transform.parent = _buttonsInMenu[_currentMenuIndex][_currentButtonIndex].transform;
        _menuSelector.transform.localPosition = Vector3.zero;
    }
    
    */


    public void Play()
    {
        StartCoroutine(WaitForFadeIn());
    }

    public void Opciones()
    {
        EventManager.ButtonSound.Invoke();
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        optionsMenuDefaultButton.Select();
    }

    public void ExitOptions()
    {
        EventManager.ButtonSound.Invoke();
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
        mainMenuDefaultButton.Select();
    }

    public void Creditos()
    {
        EventManager.ButtonSound.Invoke();
        SceneManager.LoadScene("Creditos");
    }

    public void QuitGame()
    {
        EventManager.ButtonSound.Invoke();
        Application.Quit();
    }

    IEnumerator  WaitForFadeIn()
    {

        _fadeInAni.SetTrigger("StartFadeIn");
       AsyncOperation async = SceneManager.LoadSceneAsync("Introduccion");

        yield return new WaitForSeconds(0.5f);
        while (!async.isDone)
        {

            EventManager.ButtonSound.Invoke();
            yield return null;
        }
    }

    
}
