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

        Submit = _controls.UI.Submit;
        Submit.Enable();
        Submit.performed += UseOnClick;
    }

    private void OnDisable()
    {
        
        Submit.Disable();

        
    }

    private void Start()
    {
        
        EventManager._OpenMenuPause.AddListener(NavigateMenuPause);
        EventManager._EnterInElevator.AddListener(NavigateElevator);

    }


    public void NavigateMenuPause()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[0]);
    }

    public void NavigateOptions()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[1]);
    }
    public void NavigateMusic()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[2]);
    }



    public void UseOnClick(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isInventoryActive)
        {

            if (GlobalBools._canSubmit)
            {
                GameObject selectObject;
                selectObject = EventSystem.current.currentSelectedGameObject;
                Button _bu = selectObject.GetComponent<Button>();

                if (_bu != null)
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
        }
    }

    public void NavigateElevator()
    {
        if(GlobalBools._isInReception)
        {
            _buttonElevator[0].interactable = false;

            var colorsbuton = _buttonElevator[0].GetComponent<Button>().colors;
            var restoreColorButton1 = _buttonElevator[1].GetComponent<Button>().colors;
            var restoreColorButton2 = _buttonElevator[2].GetComponent<Button>().colors;

            colorsbuton.normalColor = Color.gray;
            restoreColorButton1.normalColor = Color.white;
            restoreColorButton2.normalColor = Color.white;

            _buttonElevator[0].GetComponent<Button>().colors = colorsbuton;
            _buttonElevator[1].GetComponent<Button>().colors = restoreColorButton1;
            _buttonElevator[2].GetComponent<Button>().colors = restoreColorButton2;

            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[3]);

        }

        if (GlobalBools._isInFirstFloor)
        {
            _buttonElevator[1].interactable = false;

            var colorsbuton = _buttonElevator[1].GetComponent<Button>().colors;
            var restoreColorButton1 = _buttonElevator[0].GetComponent<Button>().colors;
            var restoreColorButton2 = _buttonElevator[2].GetComponent<Button>().colors;

            colorsbuton.normalColor = Color.gray;
            restoreColorButton1.normalColor = Color.white;
            restoreColorButton2.normalColor = Color.white;
            _buttonElevator[1].GetComponent<Button>().colors = colorsbuton;
            _buttonElevator[0].GetComponent<Button>().colors = restoreColorButton1;
            _buttonElevator[2].GetComponent<Button>().colors = restoreColorButton2;


            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[4]);

        }
        if (GlobalBools._isInSecondFloor)
        {
            _buttonElevator[2].interactable = false;

            var colorsbuton =_buttonElevator[2].GetComponent<Button>().colors;
            var restoreColorButton1 = _buttonElevator[0].GetComponent<Button>().colors;
            var restoreColorButton2 = _buttonElevator[1].GetComponent<Button>().colors;
            colorsbuton.normalColor = Color.gray;
            restoreColorButton1.normalColor = Color.white;
            restoreColorButton2.normalColor = Color.white;

            _buttonElevator[2].GetComponent<Button>().colors = colorsbuton;
            _buttonElevator[0].GetComponent<Button>().colors = restoreColorButton1;
            _buttonElevator[1].GetComponent<Button>().colors = restoreColorButton2;
            
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(_firstObjectToSelect[5]);

        }
    }

}
