using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTab : MonoBehaviour
{
    public GameObject[] _tabViews;
    GameObject[] conversations;
    int currentConversation = 0;
    private int _allTabViews;

    [SerializeField] private int _currentPagIndex;

    void Start()
    {
        _allTabViews = gameObject.transform.childCount;

        _tabViews = new GameObject[_allTabViews];

        for (int i = 0; i < _allTabViews; i++)
        {
            _tabViews[i] = gameObject.transform.GetChild(i).gameObject;
            _tabViews[i].SetActive(false);
        }

        //conversations = new GameObject[GameManager.PastConversations.Length];
        //for (int i = 0; i < GameManager.PastConversations.Length; i++)
        //{
        //    conversations[i] = Resources.Load<GameObject>("/Conversations/Conversation" + conversations[i]);
        //    conversations[i].transform.SetParent(_tabViews[0].transform);
        //    conversations[i].transform.localPosition = Vector3.zero;
        //}
    }
    
    private void Update()
    {
        BrowsePag();
        //print(name + " update");
        
    }

    void BrowsePag() //Moverse por las paginas
    {
        //if (Input.GetKeyDown(KeyCode.D) && _currentPagIndex < 3) //Hacia la derecha
        //{
        //    _tabViews[_currentPagIndex].SetActive(false);
        //    _currentPagIndex++;
        //    _tabViews[_currentPagIndex].SetActive(true);

        //}

        //if (Input.GetKeyDown(KeyCode.A) && _currentPagIndex > 0) //Hacia la izquierda
        //{
        //    _tabViews[_currentPagIndex].SetActive(false);
        //    _currentPagIndex--;
        //    _tabViews[_currentPagIndex].SetActive(true);
        //}

        //_tabViews[_currentPagIndex].SetActive(true);
    }


    private void OnEnable() //Vuelve a la pagina 0 (en el array) al cambiar de opcion
    {
        if (_tabViews.Length > 0)
        {
            _tabViews[_currentPagIndex].SetActive(false);
            _currentPagIndex = 0;
            _tabViews[_currentPagIndex].SetActive(true);
        }
    }
}
