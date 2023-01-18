using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UserActions _controls;
    private InputAction OpenClose;
    private InputAction Inventory;

    [SerializeField]private GameObject _menuPauseCanvas;
    [SerializeField]private GameObject _elevatorUI;
    bool _isElevatorUiActive = false;

    private void Awake()
    {
        _controls = new UserActions();
        _menuPauseCanvas = GameObject.Find("BasePausemenu");
        _elevatorUI = GameObject.Find("ElevatorCanvas");
    }

    private void Start()
    {
        EventManager._EnterInElevator.AddListener(ActiveElevatorUI);
        EventManager._CloseElevator.AddListener(FalseUIElevator);
        if (_menuPauseCanvas != null)
            _menuPauseCanvas.SetActive(false);
        if (_elevatorUI != null)
            _elevatorUI.SetActive(false);
    }

    public void OnEnable()
    {

        OpenClose = _controls.MenuPause.OpenClose;
        OpenClose.Enable();
        OpenClose.performed += UseMenu;
        Inventory = _controls.Player.Inventory;
        Inventory.Enable();
        Inventory.performed += CloseMenu;

    }

    public void OnDisable()
    {
        OpenClose.Disable();
        Inventory.Disable();
    }

    private void UseMenu(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isMenuPauseActive)
        {

            _menuPauseCanvas.SetActive(true);
            EventManager._OpenMenuPause.Invoke();
            GlobalBools._isInventoryActive = false;
            GlobalBools._isMenuPauseActive = true;
            GlobalBools._canSubmit = true;


        }
        else
        {
            _menuPauseCanvas.SetActive(false);
            GlobalBools._isMenuPauseActive = false;
            GlobalBools._canSubmit = false;


        }
    }

    private void CloseMenu(InputAction.CallbackContext context)
    {
        if(GlobalBools._isMenuPauseActive)
        {
            _menuPauseCanvas.SetActive( false);
            GlobalBools._isMenuPauseActive = false;
            GlobalBools._canSubmit = false;

        }
    }

    public void ActiveElevatorUI()
    {
        _elevatorUI.SetActive(true);
        _isElevatorUiActive = true;
    }
    public void FalseUIElevator()
    {
        _elevatorUI.SetActive(false);
        _isElevatorUiActive = false;
        GlobalBools._canSubmit = false;

    }
    public void GoMenuPrincipalMain()
    {
        GlobalBools._canSubmit = false;

        SceneManager.LoadScene(0);
    }
}
