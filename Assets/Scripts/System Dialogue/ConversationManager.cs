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
        GameManager._isDialoguesLastLine = false;
        GameManager._nextLineActive = true;
        GameManager._isTalking = true;
        LogicalDialogueSystem.StartConversation(_conversation);
      
    }

    public void CheckTheConversation(Conversation _npcConversation)
    {

        _conversation = _npcConversation;
        _dialogueBox.SetActive(true);
        StartConversation();
    }
}
