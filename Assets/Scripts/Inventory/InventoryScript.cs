using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    void Start()
    {
        _allTab = _slotTab.transform.childCount;

        _tab = new GameObject[_allTab];

        for (int i = 0; i < _allTab; i++)
        {
            _tab[i] = _slotTab.transform.GetChild(i).gameObject;
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
        _tabOptions[_currentTabIndex].SetActive(false);

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _inventoryEnabled =! _inventoryEnabled; 
        }

        if (_inventoryEnabled)
        {
            _inventory.SetActive(true); 
            //poner un if con una booleana que indique que se ha seleccionado una tab //o no, no lo se la verdad
            Browse();
        }
        else
        {
            _inventory.SetActive(false);
        }
    }

    public void Browse() //Moverse por el inventario
    {
        if (Input.GetKeyDown(KeyCode.E)) //Hacia la derecha
        {
            _currentTabIndex = (_currentTabIndex + 1) % _tab.Length;
            
        }

        if (Input.GetKeyDown(KeyCode.Q)) //Hacia la izquierda
        {
            _currentTabIndex = (_currentTabIndex - 1 + _tab.Length) % _tab.Length;
            
        }



        _tabSelector.transform.position = _tab[_currentTabIndex].transform.position;

        _tabOptions[_currentTabIndex].SetActive(true);
    }
}
