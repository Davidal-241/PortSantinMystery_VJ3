using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;

public class EventSystemController : MonoBehaviour
{
    [SerializeField] GameObject[] _objectToPass;
    [SerializeField] EventSystem _event;

    [SerializeField] UserActions _controls;
    private InputAction OpenClose;
    private InputAction Inventory;
    private InputAction Submit;
    private InputAction ChangeInver;

    private void Awake()
    {
        _controls = new UserActions();
    }
    public void OnEnable()
    {

        OpenClose = _controls.MenuPause.OpenClose;
        OpenClose.Enable();
        OpenClose.performed += OptionsMenu;

        Inventory = _controls.Player.Inventory;
        Inventory.Enable();
        Inventory.performed += InventoryOpen;

        Submit = _controls.UI.Submit;
        Submit.Enable();
        Submit.performed += SubmitSelect;

        ChangeInver = _controls.UI.Navigate;
        ChangeInver.Enable();
        ChangeInver.performed += ChangeInventary;
    }

    public void OnDisable()
    {
        OpenClose.Disable();
        Inventory.Disable();
        Submit.Disable();
        ChangeInver.Disable();
    }

    private void Start()
    {
        EventManager._checkNotes.AddListener(ReadingNotes);
    }

    void OptionsMenu(InputAction.CallbackContext context)
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_objectToPass[1]);
       
        
    }

    void InventoryOpen(InputAction.CallbackContext context)
    {
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(_objectToPass[0]);

    }


    public void OptionsFirstSelect()
    {
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(_objectToPass[3]);

    }

    


    public void ExitMusic()
    {
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(_objectToPass[4]);

    }

    public void SubmitSelect(InputAction.CallbackContext context)
    {
        ((InputSystemUIInputModule)EventSystem.current.currentInputModule).submit =
     InputActionReference.Create(Submit);
    }

    public void ReadingNotes()
    {
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(_objectToPass[5]);
    }

    public void ChangeInventary()
    {
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(_objectToPass[6]);

    }
}
