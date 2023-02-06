using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaDialogueManager : MonoBehaviour, IInteractable
{
    public Conversation _lunasCurrentDialogue;
    public static bool _hasAlreadyTalkedToLuna = false;
    public static bool _lunaDoesntWantToTalk = false;

    bool _isItLunaMainDialogue = true;

    public void Interact()
    {
        SearchDialogues();
    }

    private void SearchDialogues()
    {
        _hasAlreadyTalkedToLuna = true;

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (!_lunaDoesntWantToTalk)
            {

                if (ProgressCheck._areWeInTheStage5)
                {
                    if (_isItLunaMainDialogue)
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
                    _isItLunaMainDialogue = true;

                    if (!ProgressCheck.canYouLeaveThehotel)
                    {
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                        ProgressCheck.canYouLeaveThehotel = true;
                    }

                }

            }
        }
        EventManager._ConversationStarts.Invoke(_lunasCurrentDialogue);

    }

}