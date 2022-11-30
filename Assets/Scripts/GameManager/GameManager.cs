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
    bool _isMenuPauseActive = false;

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
        print("Entra");
        if (!_isMenuPauseActive)
        {
            Time.timeScale = 0f;

            _menuPauseCanvas.SetActive(true);
            EventManager._CloseInventory.Invoke();
            GlobalBools._canOpenInventory = false;
            GlobalBools._isInventoryActive = false;
            _isMenuPauseActive = true;
        }
        else
        {
            _menuPauseCanvas.SetActive(false);
            _isMenuPauseActive = false;
        }
    }

    private void CloseMenu(InputAction.CallbackContext context)
    {
        if(_isMenuPauseActive)
        {
            _menuPauseCanvas.SetActive( false);
            _isMenuPauseActive = false;
        }
    }

    public void GoMenuPrincipalMain()
    {
        SceneManager.LoadScene(0);
    }
}
