using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour
{
   public Conversation _conversation;

    [SerializeField] GameObject _dialogueBox;

    private void Start()
    {
        _dialogueBox = GameObject.Find("DialogueBox");


        EventManager._ConversationStarts.AddListener(CheckTheConversation);
        EventManager._DoorDialogue.AddListener(DoorConversation);
        EventManager._CesarDialoguesEvent.AddListener(CesarDialogues);

        if (_dialogueBox != null)
            _dialogueBox.SetActive(false);

    }

    public void StartConversation()
    {
        GlobalBools._isDialoguesLastLine = false;
        GlobalBools._nextLineActive = true;
        GlobalBools._isTalking = true;
        LogicalDialogueSystem.StartConversation(_conversation);
      
    }

    public void DoorConversation()
    {
        _conversation = null;

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage5)
            {

                _conversation = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                _dialogueBox.SetActive(true);
                StartConversation();
                ProgressCheck.canYouLeaveThehotel = true;
            }
        }

    }


    public void CesarDialogues()
    {
        
            if (ProgressCheck._areWeInTheSecondPart)
            {
                if (ProgressCheck._areWeInTheStage2)
                {
                    if (!GlobalBools._hasAlreadyTalkedToJorge)
                    {
                    // currentConvoJorge = Elevator.string

                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                        _dialogueBox.SetActive(true);
                        print(_dialogueBox.activeInHierarchy);
                        StartConversation();
                    }

                    if (!ProgressCheck._canUseElevatorToGoDown && GlobalBools._hasAlreadyTalkedToJorge)
                    {
                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_02");
                        _dialogueBox.SetActive(true);
                        StartConversation();
                    }
                }

                if (ProgressCheck._areWeInTheStage3)
                {
                    if (!ProgressCheck._didYouLeaveTheSuitcase)
                    {
                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                        _dialogueBox.SetActive(true);
                        StartConversation();
                    }
                }

                if (ProgressCheck._areWeInTheStage4)
                {
                    if (ProgressCheck._didYouInteractWithTheGlasses)
                    {
                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_04");
                        _dialogueBox.SetActive(true);
                        StartConversation();
                    }
                }

                if (ProgressCheck._areWeInTheStage5)
                {
                    if (!GlobalBools._hasAlreadyTalkedToLuna)
                    {
                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_05");
                        _dialogueBox.SetActive(true);
                        StartConversation();
                    }

                    if (!GlobalBools._hasAlreadyTalkedToCenturion)
                    {
                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_06");
                        _dialogueBox.SetActive(true);
                        StartConversation();
                    }
                }

                if (ProgressCheck._areWeInTheStage6)
                {
                    if (!GlobalBools._hasAlreadyTalkedToCenturion)
                    {
                        _conversation = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_07");
                        _dialogueBox.SetActive(true);
                        StartConversation();
                    }
                }
            }
        
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
        _conversation = _npcConversation;
        _dialogueBox.SetActive(true);
        StartConversation();
    }
}
