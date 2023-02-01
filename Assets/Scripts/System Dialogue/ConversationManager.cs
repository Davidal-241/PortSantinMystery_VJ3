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
        print("Va");
        GlobalBools._isTalking = true;
        LogicalDialogueSystem.StartConversation(_conversation);
      
    }


    //public void LunaWalkingDialogues()
    //{

    //    if (ProgressCheck._areWeInTheThirdPart)
    //    {

    //        if (ProgressCheck._areWeInTheStage1)
    //        {
    //            _conversation = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_03");
    //            _dialogueBox.SetActive(true);
    //            StartConversation();
    //        }
    //    }
    //}





    //private void Update()
    //{



    //    //if (GlobalBools._isTalking)
    //    //{
    //    //    if (_dialogueBox == null)
    //    //    {
    //    //        _dialogueBox = GameObject.Find("DialogueBox");
    //    //        _dialogueBox.SetActive(true);
    //    //    }
    //    //}
    //}

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
