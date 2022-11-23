using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UserActions _controls;
 private InputAction OpenClose;

    [SerializeField]private GameObject _menuPauseCanvas;


    private void Awake()
    {
        _controls = new UserActions();
        _menuPauseCanvas = GameObject.Find("MenuPauseCanvas");
    }

    private void Start()
    {
        _menuPauseCanvas.SetActive(false);
    }

    public void OnEnable()
    {

        OpenClose = _controls.MenuPause.OpenClose;
        OpenClose.Enable();
        OpenClose.performed += UseMenu;

       
    }

    public void OnDisable()
    {
        OpenClose.Disable();
       
    }

    private void UseMenu(InputAction.CallbackContext context)
    {
        print("Entra");
        _menuPauseCanvas.SetActive(true);

    }

    public void GoMenuPrincipalMain()
    {
        SceneManager.LoadScene(0);
    }
}
