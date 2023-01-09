using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    private bool _inventoryEnabled;

    public GameObject _inventory;

    private int _allTab;

    private int _enabledSlots; // borrar

    private GameObject[] _tab;

    public GameObject _slotTab;

    [SerializeField] private GameObject _tabSelector;
    private int _currentTabIndex;

    
    
    private GameObject[] _tapViews;
    private int _allTapViews;
    public GameObject _slotTapViews;

    [SerializeField] private GameObject[] _options;
    
    void Start()
    {
        _allTab = _slotTab.transform.childCount;

        _tab = new GameObject[_allTab];

        for (int i = 0; i < _allTab; i++)
        {
            _tab[i] = _slotTab.transform.GetChild(i).gameObject;

            if (_tab[i].GetComponent<Tab>()._item == null)
            {
                _tab[i].GetComponent<Tab>()._empty = true;
            }
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


    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _inventoryEnabled =! _inventoryEnabled; 
        }

        if (_inventoryEnabled)
        {
            _inventory.SetActive(true); 
            //poner un if con una booleana que indique que se ha seleccionado una tab
            Browse();
        }
        else
        {
            _inventory.SetActive(false);
        }
    }

    public void Browse() //Moverse por el inventario
    {
        if (Input.GetKeyDown(KeyCode.D)) //Hacia la derecha
        {
            _currentTabIndex = (_currentTabIndex + 1) % _tab.Length;
        }

        if (Input.GetKeyDown(KeyCode.A)) //Hacia la izquierda
        {
            _currentTabIndex = (_currentTabIndex - 1 + _tab.Length) % _tab.Length;
        }

        

        _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;

        if (Input.GetKeyDown(KeyCode.S))
        {
            _options[_currentTabIndex].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _options[_currentTabIndex].SetActive(false);
        }
    }
}
