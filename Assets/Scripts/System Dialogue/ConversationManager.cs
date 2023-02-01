using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour
{
   public Conversation _conversation;

    [SerializeField] GameObject _dialogueBox;

    private void Awake()
    {
        _dialogueBox.SetActive(false);

    }
    private void Start()
    {


        EventManager._ConversationStarts.AddListener(CheckTheConversation);

       

    }

    public void StartConversation()
    {
        GlobalBools._isDialoguesLastLine = false;
        GlobalBools._nextLineActive = true;
        GlobalBools._isTalking = true;
        LogicalDialogueSystem.StartConversation(_conversation);
      
    }

    public void CheckTheConversation(Conversation _npcConversation)
    {
        print(_conversation);
        print(_dialogueBox);

        _conversation = _npcConversation;
        _dialogueBox.SetActive(true);
        print("a");
        StartConversation();
    }
}
