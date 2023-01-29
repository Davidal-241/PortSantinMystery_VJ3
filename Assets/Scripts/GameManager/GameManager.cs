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

    private void Awake()
    {
        _controls = new UserActions();
        _menuPauseCanvas = GameObject.Find("BasePausemenu");
    }

    private void Start()
    {
        if (_menuPauseCanvas != null)
            _menuPauseCanvas.SetActive(false);
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

    public void GoMenuPrincipalMain()
    {
        GlobalBools._canSubmit = false;

        SceneManager.LoadScene(0);
    }
}
