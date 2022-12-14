using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    private bool _inventoryEnabled;

    public GameObject _inventory;

    private int _allTap;

    private int _enabledSlots; // borrar

    private GameObject[] _tap;

    public GameObject _slotTap;

    [SerializeField] private GameObject _selector;
    private int _iD;

    
    
    private GameObject[] _tapViews;
    private int _allTapViews;
    public GameObject _slotTapViews;


    
    void Start()
    {
        _allTap = _slotTap.transform.childCount;

        _tap = new GameObject[_allTap];

        for (int i = 0; i < _allTap; i++)
        {
            _tap[i] = _slotTap.transform.GetChild(i).gameObject;

            if (_tap[i].GetComponent<Tap>()._item == null)
            {
                _tap[i].GetComponent<Tap>()._empty = true;
            }
        }

        //for (int i = 0; i < _allTapViews; i++)
        //{
        //    _tapViews[i] = _slotTapViews.transform.GetChild(i).gameObject;

        //    if (_tapViews[i].GetComponent<referencia a un nuevo script de tapView>()._item == null)
        //    {
        //        _tapViews[i].GetComponent<referencia a un nuevo script de tapView>()._empty = true;
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
            _inventory.SetActive(true); Browse();
        }
        else
        {
            _inventory.SetActive(false);
        }
    }

    public void Browse() //Moverse por el inventario
    {
        if (Input.GetKeyDown(KeyCode.D) && _iD<_tap.Length-1) //Hacia la derecha
        {
            _iD++;
        }

        if (Input.GetKeyDown(KeyCode.A) && _iD > 0) //Hacia la izquierda
        {
            _iD--;
        }

        

        _selector.transform.position = _tap[_iD].transform.position;
    }
}
