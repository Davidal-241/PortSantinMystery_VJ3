using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvo : MonoBehaviour
{
   public Conversation convo;

    [SerializeField] GameObject _dialogueBox;

    private void Start()
    {
        _dialogueBox = GameObject.Find("DialogueBox");


        EventManager._ConversationStarts.AddListener(CheckConve);
        EventManager._DoorDialogue.AddListener(DoorConversation);
        EventManager._CesarDialoguesEvent.AddListener(CesarDialogues);

        if (_dialogueBox != null)
            _dialogueBox.SetActive(false);

    }

    public void StartConve()
    {
        GlobalBools._isDialoguesLastLine = false;
        GlobalBools._nextLineActive = true;
        GlobalBools._isTalking = true;
        DialogueManager.StartConversation(convo);
      
    }

    public void DoorConversation()
    {
        convo = null;

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage5)
            {

                convo = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                _dialogueBox.SetActive(true);
                StartConve();
                ProgressCheck._canYouExit = true;
            }
        }

    }

    public void LunaWalkingDialogues()
    {

        if (ProgressCheck._areWeInTheThirdPart)
        {

            if (ProgressCheck._areWeInTheStage1)
            {
                convo = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_03");
                _dialogueBox.SetActive(true);
                StartConve();
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

                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                        _dialogueBox.SetActive(true);
                        print(_dialogueBox.activeInHierarchy);
                        StartConve();
                    }

                    if (!ProgressCheck._canUseElevatorToGoDown && GlobalBools._hasAlreadyTalkedToJorge)
                    {
                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_02");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }

                if (ProgressCheck._areWeInTheStage3)
                {
                    if (!ProgressCheck._didYouLeaveTheSuitcase)
                    {
                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }

                if (ProgressCheck._areWeInTheStage4)
                {
                    if (ProgressCheck._didYouInteractWithTheGlasses)
                    {
                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_04");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }

                if (ProgressCheck._areWeInTheStage5)
                {
                    if (!GlobalBools._isknowLuna)
                    {
                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_05");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }

                    if (!GlobalBools._isknowCenturion)
                    {
                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_06");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }

                if (ProgressCheck._areWeInTheStage6)
                {
                    if (!GlobalBools._isknowCenturion)
                    {
                        convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_07");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }
            }
        
    }

    private void Update()
    {

     

        //if (GlobalBools._isTalking)
        //{
        //    if (_dialogueBox == null)
        //    {
        //        _dialogueBox = GameObject.Find("DialogueBox");
        //        _dialogueBox.SetActive(true);
        //    }
        //}
    }

    public void CheckConve()
    {
       

        if (GlobalBools._isCloseToLuna)
        {
            if (ProgressCheck._areWeInTheSecondPart)
            {
                GlobalBools._isknowLuna = true;
                if (!GlobalBools._cantTalkLuna)
                {

                    if (ProgressCheck._areWeInTheStage5)
                    {
                        if (!GlobalBools._canLunaTalkMore)
                        {
                            convo = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_01");
                            _dialogueBox.SetActive(true);
                            GlobalBools._canLunaTalkMore = true;
                            StartConve();

                        }
                        if (GlobalBools._canLunaTalkMore)
                        {
                            convo = Resources.Load<Conversation>("Luna/GF_Dialogues/Luna_GF_Dialogue_01");
                            _dialogueBox.SetActive(true);
                            GlobalBools._cantTalkLuna = true;
                            StartConve();
                        }
                    }
                }
                if (ProgressCheck._areWeInTheStage6)
                {
                    if (!ProgressCheck._canYouExit)
                    {
                        if (ProgressCheck._youTryGoOutside)
                        {
                            convo = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                            _dialogueBox.SetActive(true);
                            StartConve();
                            ProgressCheck._canYouExit = true;
                        }
                    }
                }
            }
        }

        if (GlobalBools._isCloseToCenturion)
        {
            GlobalBools._isknowCenturion = true;
            if (ProgressCheck._areWeInTheSecondPart)
            {
                if (ProgressCheck._areWeInTheStage6)
                {
                    if (!GlobalBools._canCenturionTalkMore)
                    {

                        convo = Resources.Load<Conversation>("Centurion/N_Dialogues/Centurion_N_Dialogue_01");
                        GlobalBools._canCenturionTalkMore = true;
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }

                    if (GlobalBools._canCenturionTalkMore)
                    {
                        convo = Resources.Load<Conversation>("Centurion/GF_Dialogues/Centurion_GF_Dialogue_01");
                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }
            }
        }



        if (GlobalBools._isCloseToJorge)
        {
            GlobalBools._hasAlreadyTalkedToJorge = true;

            if (ProgressCheck._areWeInTheSecondPart)
            {

                if (ProgressCheck._areWeInTheStage2)
                {
                    if (!GlobalBools._canJorgeTalkMore)
                    {
                        convo = Resources.Load<Conversation>("Jorge/N_Dialogues/Jorge_N_Dialogue_01");
                        _dialogueBox.SetActive(true);
                        ProgressCheck._finishMainDialogueJorge = true;

                        StartConve();
                    }



                    if (GlobalBools._canJorgeTalkMore)
                    {
                        if (ProgressCheck._areWeInTheStage2)
                        {
                            print("Va");
                            int _randomConversationIndex = Random.Range(0, 2);

                            if (_randomConversationIndex == 0)
                            {
                                convo = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_01");
                                _dialogueBox.SetActive(true);

                                StartConve();
                            }
                            if (_randomConversationIndex == 1)
                            {
                                convo = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                                _dialogueBox.SetActive(true);
                                StartConve();
                            }
                            print(_dialogueBox.activeInHierarchy);
                        }



                        if (ProgressCheck._areWeInTheStage5)
                        {
                            convo = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                            _dialogueBox.SetActive(true);
                            StartConve();
                        }
                    }
                }

               
            }
        }


    }
}
