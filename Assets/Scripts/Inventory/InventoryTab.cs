using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InventoryTab : MonoBehaviour
{
    public GameObject[] _tabViews;
    GameObject[] conversations;
    int currentConversation = 0;
    private int _allTabViews;

    [SerializeField] private int _currentPagIndex;

    [SerializeField] GameObject[] allConversations;
    GameObject[] unlockedConversations;

    UserActions _controls;

    bool _unlocked = false;

    [SerializeField] bool loadTabItems = false;

    private void Awake()
    {
        if (loadTabItems)
        {
            foreach (GameObject conversation in allConversations)
                conversation.SetActive(false);

            int[] unlockedConversationIndexes = GameManager.GetConversations();
            unlockedConversations = new GameObject[unlockedConversationIndexes.Length];


            for (int i = 0; i < unlockedConversationIndexes.Length; i++)
            {
                allConversations[unlockedConversationIndexes[i]].SetActive(true);
                unlockedConversations[i] = allConversations[unlockedConversationIndexes[i]];
            }

        }
    }

    void InputSet(UserActions input)
    {
        _controls = input;

        
        _controls.Inventory.NavigateLeft.performed += PreviousTabItem;
        _controls.Inventory.NavigateRight.performed += NextTabItem;
    }

    void Start()
    {
        EventManager.enterInSubTab.AddListener(ToggleMovementLock);
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
    
    void ToggleMovementLock()
    {
        _unlocked = !_unlocked;
        print(name + " " + _unlocked);

        //if (!_unlocked)
        //{
        //    _unlocked = true;
        //    print(_unlocked);
        //}
        //else
        //{
        //    _unlocked = false;
        //}
    }

    void PreviousTabItem(InputAction.CallbackContext context)
    {
        if (_unlocked)
        {
            print("Va");

            if ( _currentPagIndex > 0)
            {

                _tabViews[_currentPagIndex].SetActive(false);
                _currentPagIndex--;
                _tabViews[_currentPagIndex].SetActive(true);

            }
        }
    }

    void NextTabItem(InputAction.CallbackContext context)
    {
        if (_unlocked)
        {
            if (_currentPagIndex < _tabViews.Length - 1)
            {

                _tabViews[_currentPagIndex].SetActive(false);
                _currentPagIndex++;
                _tabViews[_currentPagIndex].SetActive(true);


            }
        }
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
