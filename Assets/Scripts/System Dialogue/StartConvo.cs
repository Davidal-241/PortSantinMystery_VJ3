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


        EventManager._Talk.AddListener(CheckConve);
        EventManager._CesarDialoguesEvent.AddListener(CesarDialogues);

        print("StartConvo");
        if (_dialogueBox != null)
            _dialogueBox.SetActive(false);

    }

    public void StartConve()
    {
        GlobalBools._nextLineActive = true;
        GlobalBools._isTalk= true;
        DialogueManager.StartConversation(convo);
      
    }

    public void DoorConversation()
    {

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage5)
            {

                convo = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                _dialogueBox.SetActive(true);
                StartConve();

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
                if (!GlobalBools._isknowJorge)
                {
                    convo = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                    _dialogueBox.SetActive(true);
                    StartConve();
                }

                if (!ProgressCheck._canUseElevatorToGoDown)
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

    public void CheckConve()
    {
        //if(GlobalBools._isdriverTalking)
        //{
        //    if(GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._isreviewerTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}

        if (GlobalBools._islunaTalking)
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

        if (GlobalBools._iscenturionTalking)
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

        if (GlobalBools._isjorgeTalking)
        {
            GlobalBools._isknowJorge = true;

            if (ProgressCheck._areWeInTheSecondPart)
            {

                if (ProgressCheck._areWeInTheStage2)
                {
                    if (!GlobalBools._canJorgeTalkMore)
                    {
                        convo = Resources.Load<Conversation>("Jorge/N_Dialogues/Jorge_N_Dialogue_01");
                        _dialogueBox.SetActive(true);
                        GlobalBools._canJorgeTalkMore = true;
                        StartConve();
                    }

                    if (GlobalBools._canJorgeTalkMore)
                    {
                        if (ProgressCheck._areWeInTheStage2)
                        {

                            int _randomConversationIndex = Random.Range(0, 1);

                            if (_randomConversationIndex == 0)
                            {
                                convo = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_01");
                            }
                            if (_randomConversationIndex == 1)
                            {
                                convo = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                            }
                        }
                        if (ProgressCheck._areWeInTheStage5)
                        {
                            convo = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                        }

                        _dialogueBox.SetActive(true);
                        StartConve();
                    }
                }

               
            }
        }


    }
}
