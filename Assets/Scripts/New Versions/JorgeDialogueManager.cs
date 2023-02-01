using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeDialogueManager : MonoBehaviour, IInteractable
{
   public Conversation _jorgesCurrentDialogue;

   public void Interact()
    {
        print(name);
        SearchDialogues();
    }


               
    private void SearchDialogues()
    {
        GlobalBools._hasAlreadyTalkedToJorge = true;

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage2)
            {
                if (GlobalBools._isItJorgesMainDialogue)
                {
                    _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/N_Dialogues/Jorge_N_Dialogue_01");
                    GlobalBools._isItJorgesMainDialogue = false;
                }
                else
                {
                    if (ProgressCheck._areWeInTheStage2)
                    {
                        int _randomConversationIndex = Random.Range(0, 2);

                        if (_randomConversationIndex == 0)
                        {
                            _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_01");
                           
                        }
                        if (_randomConversationIndex == 1)
                        {
                            _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                           
                        }
                    }

                    if (ProgressCheck._areWeInTheStage5)
                    {
                        _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                    }
                }
            }
        }

        EventManager._ConversationStarts.Invoke(_jorgesCurrentDialogue);
    }
}
