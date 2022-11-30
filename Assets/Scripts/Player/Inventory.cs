using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

using UnityEngine.UI; 

public class Inventory : MonoBehaviour
{

    [SerializeField] GameObject _Panel, Inventario, Notas, Fotos, Controles, KeyBottom, GamePadBottom;
    [SerializeField]Image _reviewer, _driver, _jorge, _luna, _centurion, _prayer;
    [SerializeField]Button _reviewerButton, _driverButton, _jorgeButton, _lunaButton, _centurionButton, _prayerButton;

    [SerializeField] UserActions _controls;
    
    private InputAction Submit;

    private void Awake()
    {
        _controls = new UserActions();
    }
    public void OnEnable()
    {
        Submit = _controls.UI.Submit;
        Submit.Enable();
        Submit.performed += EnterInNotes;

    }

    public void OnDisable()
    {
        Submit.Disable();

    }


    public void EnterInNotes(InputAction.CallbackContext context)
    {
        if(Notas.activeSelf == true)
        {
            EventManager._checkNotes.Invoke();
        }
      
    }

    private void Start()
    {
        EventManager._OpenInventory.AddListener(OpenWindow);
        EventManager._CloseInventory.AddListener(CloseWindow);
        if (_Panel != null)
            _Panel.SetActive(false);
    }
    

    private void PlayerSpokeTo()
    {
        if(GlobalBools._isknowCenturion)
        {
            _centurionButton.enabled = true;
        }
        if (GlobalBools._isknowDriver)
        {
            _driverButton.enabled = true;
        }
        if (GlobalBools._isknowJorge)
        {
            _jorgeButton.enabled = true;
        }
        if (GlobalBools._isknowLuna)
        {
            _lunaButton.enabled = true;
        }
        if (GlobalBools._isknowPrayer)
        {
            _prayerButton.enabled = true;
        }
        if (GlobalBools._isknowReviewer)
        {
            _reviewerButton.enabled = true;
        }
    }

    private void OpenWindow()
    {
        _Panel.SetActive(true);
        Inventario.SetActive(true);
        _reviewer.enabled = false;
        _driver.enabled = false;
        _jorge.enabled = false; 
        _luna.enabled = false; 
        _centurion.enabled = false;
        _prayer.enabled = false;
    }

    private void CloseWindow()
    {
        _Panel.SetActive(false);
    }


    public void ChangeArchive1()
    {

        Inventario.SetActive(true);
        EventManager._changePageInventory.Invoke();
        Notas.SetActive(false);
        Fotos.SetActive(false);
        Controles.SetActive(false);
    }

    public void ChangeArchive2()
    {
        EventManager._changePageNotes.Invoke();

        Inventario.SetActive(false);
        Notas.SetActive(true);
        PlayerSpokeTo();
        Fotos.SetActive(false);
        Controles.SetActive(false);

    }

    public void ChangeArchive3()
    {
        EventManager._changePagePhotos.Invoke();

        Inventario.SetActive(false);
        Notas.SetActive(false);
        Fotos.SetActive(true);
        Controles.SetActive(false);

    }

    public void ChangeArchive4()
    {
        EventManager._changePageControlls.Invoke();

        Inventario.SetActive(false);
        Notas.SetActive(false);
        Fotos.SetActive(false);
        Controles.SetActive(true);
        KeyBottom.SetActive(true);

    }



    public void ChangeImageControllersKey()
    {

        KeyBottom.SetActive(true);
        GamePadBottom.SetActive(false);

    }

    public void ChangeImageControllersGamePad()
    {
        KeyBottom.SetActive(false);
        GamePadBottom.SetActive(true);

    }


    public void Reviewer()
    {
        _reviewer.enabled = true;
        _driver.enabled = false;
        _jorge.enabled = false;
        _luna.enabled = false;
        _centurion.enabled = false;
        _prayer.enabled = false;
    }
    //public void Driver()
    //{
    //    _reviewer.enabled = false;
    //_driver.enabled = false;
    //    _jorge.enabled = false; 
    //    _luna.enabled = false; 
    //    _centurion.enabled = false;
    //    _prayer.enabled = false;
    ////}
    public void Jorge()
    {

        _reviewer.enabled = false;
        _driver.enabled = false;
        _jorge.enabled = true;
        _luna.enabled = false;
        _centurion.enabled = false;
        _prayer.enabled = false;
    }
    public void Luna()
    {
        _reviewer.enabled = false;
        _driver.enabled = false;
        _jorge.enabled = false;
        _luna.enabled = true;
        _centurion.enabled = false;
        _prayer.enabled = false;
    }

    public void Prayer()
    {
        _reviewer.enabled = false;
        _driver.enabled = false;
        _jorge.enabled = false;
        _luna.enabled = false;
        _centurion.enabled = false;
        _prayer.enabled = true;
    }

    public void Centurion()
    {
        _reviewer.enabled = false;
        _driver.enabled = false;
        _jorge.enabled = false;
        _luna.enabled = false;
        _centurion.enabled = true;
        _prayer.enabled = false;
    }

}
