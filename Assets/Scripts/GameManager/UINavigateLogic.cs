using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;

public class UINavigateLogic : MonoBehaviour
{

    [SerializeField] GameObject[] _firstObjectToSelect;
    [SerializeField] EventSystem _event;

    UserActions _controls;

    private InputAction _navegateEnterSubPanel;
    private InputAction _navegateExitSubPanel;
    private InputAction Submit;

    private void Awake()
    {
        _controls = new UserActions();
    }

    private void OnEnable()
    {
        _navegateEnterSubPanel = _controls.UI.EnterInSubPanel;
        _navegateEnterSubPanel.Enable();
        _navegateEnterSubPanel.performed += EnterInNotesPanel;

        _navegateExitSubPanel = _controls.UI.ExitInSubPanel;
        _navegateExitSubPanel.Enable();
        _navegateExitSubPanel.performed += ExitNotesPanel;

        Submit = _controls.UI.Submit;
        Submit.Enable();
        Submit.performed += UseOnClick;
    }

    private void OnDisable()
    {
        _navegateEnterSubPanel.Disable();
        Submit.Disable();

        _navegateExitSubPanel.Disable();
    }

    private void Start()
    {
        EventManager._OpenInventory.AddListener(InventoryNavegate);
        EventManager._changePageInventory.AddListener(InventoryNavegate);
        EventManager._changePageNotes.AddListener(NotesIsSelect);
        EventManager._changePagePhotos.AddListener(PhotosIsSelect);
        EventManager._changePageControlls.AddListener(ControlsIsSelect);
    }


    public void InventoryNavegate()
    {

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[0]);
        GlobalBools._isInventoryActive = true;

    }

    public void NotesIsSelect()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[1]);
    }
    public void PhotosIsSelect()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[2]);
    }
    public void ControlsIsSelect()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[3]);
    }


    public void EnterInNotesPanel(InputAction.CallbackContext context)
    {
        if (GlobalBools._isInventoryActive)
        {
            if (!GlobalBools._isInNotesPanel)
            {
                GlobalBools._isInNotesPanel = true;
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[4]);
            }
        }

    }

    public void ExitNotesPanel(InputAction.CallbackContext context)
    {
        if (GlobalBools._isInventoryActive)
        {
            if (GlobalBools._isInNotesPanel)
            {
                GlobalBools._isInNotesPanel = false;
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[1]);
            }
        }
    }



    public void NavigateMenuPause()
    {

    }



    public void UseOnClick(InputAction.CallbackContext context)
    {
        if (GlobalBools._isInventoryActive)
        {
            GameObject selectObject;
            selectObject = EventSystem.current.currentSelectedGameObject;
            selectObject.GetComponent<Button>().onClick.Invoke();
        }
    }

}
