using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaDialogueManager : MonoBehaviour, IInteractable
{
    public Conversation _lunasCurrentDialogue;

    public void Interact()
    {
        SearchDialogues();
    }

    private void SearchDialogues()
    {
        GlobalBools._hasAlreadyTalkedToLuna = true;

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (!GlobalBools._lunaDoesntWantToTalk)
            {

                if (ProgressCheck._areWeInTheStage5)
                {
                    if (GlobalBools._isItLunaMainDialogue)
                    {
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_01");
                    }
                    else
                    {
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/GF_Dialogues/Luna_GF_Dialogue_01");
                    }
                }

                if (ProgressCheck._areWeInTheStage6)
                {
                    GlobalBools._isItLunaMainDialogue = true;

                    if (ProgressCheck.cantYouLeaveThehotel)
                    {
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                        ProgressCheck.cantYouLeaveThehotel = true;
                    }

                }

            }
        }
    }

}
