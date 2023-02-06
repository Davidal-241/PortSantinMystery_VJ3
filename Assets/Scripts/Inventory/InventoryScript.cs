using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InventoryScript : MonoBehaviour
{
    private bool _inventoryEnabled;

    [SerializeField] private GameObject _inventory;

    private int _allTab;

    [SerializeField] private GameObject[] _tab;

    [SerializeField] private GameObject _slotTab;

    [SerializeField] private GameObject _tabSelector;
    [SerializeField] private int _currentTabIndex;

    [SerializeField] private GameObject[] _tabOptions;

    
    [SerializeField] UserActions _controls;
 
    
   

    private void Awake()
    {
        EventManager._InputSet.AddListener(InputSet);

    }
    void InputSet(UserActions input)
    {
        _controls = input;

        _controls.Player.Inventory.performed += OpenInventory;
        _controls.UI.NavigateLeft.performed += LeftMoveSuperioTab;
        _controls.UI.NavigateRight.performed += RightMoveSuperioTab;
    }
    void Start()
    {
        _inventory.SetActive(false);
        _allTab = _slotTab.transform.childCount;

        _tab = new GameObject[_allTab];

        for (int i = 0; i < _allTab; i++)
        {
            _tab[i] = _slotTab.transform.GetChild(i).gameObject;
            _tabOptions[i].SetActive(false);

        }


        

        

        //navegar por los paneles

        //for (int i = 0; i < _allTapViews; i++)
        //{
        //    _tapViews[i] = _slotTapViews.transform.GetChild(i).gameObject;

        //    if (_tapViews[i].GetComponent<TapView>()._item == null)
        //    {
        //        _tapViews[i].GetComponent<TapView>()._empty = true;
        //    }
        //}

        
    }

    private void Update()
    {
        if (GameManager._isMenuPauseActive)
        {
            _inventory.SetActive(false);
        }
         _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;

            _tabOptions[_currentTabIndex].SetActive(true);

       
    }
    public void OpenInventory(InputAction.CallbackContext context)
    {

        if (GameManager._isInventoryActive)
        {
            _inventory.SetActive(false);
            _tabOptions[_currentTabIndex].SetActive(false);
            //GameManager._playerCanMove = true;
            GameManager._isOpenInventory = false;
        }
        else
        {
            _inventory.SetActive(true);
            _currentTabIndex = 0;
            _tabOptions[_currentTabIndex].SetActive(true);
            //GameManager._playerCanMove = false;
            GameManager._isOpenInventory = true;
        }

    }

    void LeftMoveSuperioTab(InputAction.CallbackContext context)
    {
        
        if (GameManager._isOpenInventory)
        {

            _tabOptions[_currentTabIndex].SetActive(false);
            _currentTabIndex = (_currentTabIndex - 1 + _tab.Length) % _tab.Length;
            _tabOptions[_currentTabIndex].SetActive(true);
            _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;


        }
    }

    void RightMoveSuperioTab(InputAction.CallbackContext context)
    {
         if (GameManager._isOpenInventory)
        {

            _tabOptions[_currentTabIndex].SetActive(false);
            _currentTabIndex = (_currentTabIndex + 1) % _tab.Length;
            _tabOptions[_currentTabIndex].SetActive(true);

            _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;

        }
    }
}
