using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab : MonoBehaviour
{
    public GameObject[] _tabViews;
    private int _allTabViews;
    public GameObject _slotTabViews;

    [SerializeField] private int _currentPagIndex;



    void Start()
    {
        print("start");
        _allTabViews = _slotTabViews.transform.childCount;

        _tabViews = new GameObject[_allTabViews];

        for (int i = 0; i < _allTabViews; i++)
        {
            _tabViews[i] = _slotTabViews.transform.GetChild(i).gameObject;
        }
    }

    
    void Update()
    {
        print("update");
        _tabViews[_currentPagIndex].SetActive(false);

        //if (Input.GetKeyDown(KeyCode.D)) //Hacia la derecha
        //{
        //    _currentPagIndex = (_currentPagIndex + 1) % _tabViews.Length;

        //}

        //if (Input.GetKeyDown(KeyCode.A)) //Hacia la izquierda
        //{
        //    _currentPagIndex = (_currentPagIndex - 1 + _tabViews.Length) % _tabViews.Length;

        //}

        //_tabViews[_currentPagIndex].SetActive(true);
    }

    public void BrowsePag() //Moverse por las paginas
    {
        if (Input.GetKeyDown(KeyCode.D)) //Hacia la derecha
        {
            _currentPagIndex = (_currentPagIndex + 1) % _tabViews.Length;

        }

        if (Input.GetKeyDown(KeyCode.A)) //Hacia la izquierda
        {
            _currentPagIndex = (_currentPagIndex - 1 + _tabViews.Length) % _tabViews.Length;

        }

        _tabViews[_currentPagIndex].SetActive(true);
    }
}
