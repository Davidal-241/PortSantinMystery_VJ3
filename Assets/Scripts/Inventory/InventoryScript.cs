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
 
    private InputAction Inventory;
    private InputAction NavegateInventoryQ;
    private InputAction NavegateInventoryE;
   

    private void Awake()
    {
        _controls = new UserActions();

    }


    public void OnEnable()
    {

      
        Inventory = _controls.Player.Inventory;
        Inventory.Enable();
        Inventory.performed += OpenInventory;

        NavegateInventoryQ = _controls.UI.PreviousTab;
        NavegateInventoryQ.Enable();
        NavegateInventoryQ.performed += PruebaQ;

        NavegateInventoryE = _controls.UI.NextTab;
        NavegateInventoryE.Enable();
        NavegateInventoryE.performed += PruebaE;


    }

    public void OnDisable()
    {
        
        Inventory.Disable();
        NavegateInventoryQ.Disable();
        NavegateInventoryE.Disable();
       
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
        if (GlobalBools._isMenuPauseActive)
        {
            _inventory.SetActive(false);
        }
         _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;

            _tabOptions[_currentTabIndex].SetActive(true);

       
    }
    public void OpenInventory(InputAction.CallbackContext context)
    {
        GlobalBools._isInventoryActive = !GlobalBools._isInventoryActive;

        if (GlobalBools._isInventoryActive)
        {
            _inventory.SetActive(true);
            GlobalBools._canSubmit = false;
            GlobalBools._playerCanMove = true;
            _currentTabIndex = 0;
            _tabOptions[_currentTabIndex].SetActive(true);
            GlobalBools._isOpenInventory = true;
        }
        else
        {
            _inventory.SetActive(false);
            _tabOptions[_currentTabIndex].SetActive(false);
            GlobalBools._playerCanMove = false;
            GlobalBools._canSubmit = true;
            GlobalBools._isOpenInventory = true;
        }

    }
    public void Browse() //Moverse por el inventario
    {
        
        if (Input.GetKeyDown(KeyCode.E)) //Hacia la derecha
        {
            print("Pipo");
            _tabOptions[_currentTabIndex].SetActive(false);
            _currentTabIndex = (_currentTabIndex + 1) % _tab.Length;
            _tabOptions[_currentTabIndex].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q)) //Hacia la izquierda
        {
            _tabOptions[_currentTabIndex].SetActive(false);
            _currentTabIndex = (_currentTabIndex - 1 + _tab.Length) % _tab.Length;
            _tabOptions[_currentTabIndex].SetActive(true);
        }

        

        _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;

        _tabOptions[_currentTabIndex].SetActive(true);
    }

    void PruebaQ(InputAction.CallbackContext context)
    {
        
        if (GlobalBools._isOpenInventory)
        {

            _tabOptions[_currentTabIndex].SetActive(false);
            _currentTabIndex = (_currentTabIndex - 1 + _tab.Length) % _tab.Length;
            _tabOptions[_currentTabIndex].SetActive(true);

           
        }
    }

    void PruebaE(InputAction.CallbackContext context)
    {
         if (GlobalBools._isOpenInventory)
        {

            _tabOptions[_currentTabIndex].SetActive(false);
            _currentTabIndex = (_currentTabIndex + 1) % _tab.Length;
            _tabOptions[_currentTabIndex].SetActive(true);



            
        }
    }
}
