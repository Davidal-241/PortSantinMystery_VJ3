using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class Inventory : MonoBehaviour
{

    [SerializeField] GameObject _Panel, Inventario, Notas, Fotos, Controles, KeyBottom, GamePadBottom;
    [SerializeField]Image _reviewer, _driver, _jorge, _luna, _centurion, _prayer;
    [SerializeField]Button _reviewerButton, _driverButton, _jorgeButton, _lunaButton, _centurionButton, _prayerButton;

    private void Start()
    {
        EventManager._OpenInventory.AddListener(OpenWindow);
        EventManager._CloseInventory.AddListener(CloseWindow);
        _Panel.SetActive(false);
    }
    

    private void PlayerSpokeTo()
    {
        if(GlobalBools._youKnowCenturion)
        {
            _centurionButton.enabled = true;
        }
        if (GlobalBools._youKnowDriver)
        {
            _driverButton.enabled = true;
        }
        if (GlobalBools._youKnowJorge)
        {
            _jorgeButton.enabled = true;
        }
        if (GlobalBools._youKnowLuna)
        {
            _lunaButton.enabled = true;
        }
        if (GlobalBools._youKnowPrayer)
        {
            _prayerButton.enabled = true;
        }
        if (GlobalBools._youKnowReviewer)
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
        Notas.SetActive(false);
        Fotos.SetActive(false);
        Controles.SetActive(false);
    }

    public void ChangeArchive2()
    {

        Inventario.SetActive(false);
        Notas.SetActive(true);
        PlayerSpokeTo();
        Fotos.SetActive(false);
        Controles.SetActive(false);

    }

    public void ChangeArchive3()
    {

        Inventario.SetActive(false);
        Notas.SetActive(false);
        Fotos.SetActive(true);
        Controles.SetActive(false);

    }

    public void ChangeArchive4()
    {

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
