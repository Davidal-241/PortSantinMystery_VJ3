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
    [SerializeField] Button[] _buttonElevator;
    [SerializeField] EventSystem _event;

    UserActions _controls;

    private InputAction _navegateEnterSubPanel;
    private InputAction _navegateExitSubPanel;
    private InputAction Submit;

    bool _isFullScreen = false;

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
        EventManager._ChangePageInventory.AddListener(InventoryNavegate);
        EventManager._OpenMenuPause.AddListener(NavigateMenuPause);
        EventManager._ChangePageNotes.AddListener(NotesIsSelect);
        EventManager._ChangePagePhotos.AddListener(PhotosIsSelect);
        EventManager._ChangePageControlls.AddListener(ControlsIsSelect);
        EventManager._EnterInElevator.AddListener(NavigateElevator);

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
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[5]);
    }

    public void NavigateOptions()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[6]);
    }
    public void NavigateMusic()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[7]);
    }



    public void UseOnClick(InputAction.CallbackContext context)
    {
        
        GameObject selectObject;
        selectObject = EventSystem.current.currentSelectedGameObject;
        Button _bu = selectObject.GetComponent<Button>();

       if(_bu != null)
        {
            selectObject.GetComponent<Button>().onClick.Invoke();
        }
        else
        {
            if (!_isFullScreen)
            {
                selectObject.GetComponent<Toggle>().isOn = true;
                print("p");
                _isFullScreen = true;
            }
            else
            {
                selectObject.GetComponent<Toggle>().isOn = false;
                _isFullScreen = false;
            }
        }
    }

    public void NavigateElevator()
    {
        if(GlobalBools._isInReception)
        {
            _buttonElevator[0].interactable = false;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[8]);

        }

        if (GlobalBools._isInFirstFloor)
        {
            _buttonElevator[1].interactable = false;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[9]);

        }
        if (GlobalBools._isInReception)
        {
            _buttonElevator[2].interactable = false;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[10]);

        }
    }

}
