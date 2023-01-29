using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenturionDialogueManager : MonoBehaviour, IInteractable
{
    public Conversation _centurionsCurrentDialogue;

    public void Interact()
    {
        SearchDialogues();
    }

    private void SearchDialogues()
    {
        GlobalBools._hasAlreadyTalkedToCenturion = true;



        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage6)
            {
                if (GlobalBools._isItCenturionsMainDialogue)
                {
                    _centurionsCurrentDialogue = Resources.Load<Conversation>("Centurion/N_Dialogues/Centurion_N_Dialogue_01");
                    GlobalBools._isItCenturionsMainDialogue = false;

                }
                else
                {
                    _centurionsCurrentDialogue = Resources.Load<Conversation>("Centurion/GF_Dialogues/Centurion_GF_Dialogue_01");
                }
            }
        }
        EventManager._ConversationStarts.Invoke(_centurionsCurrentDialogue);

    }


}
