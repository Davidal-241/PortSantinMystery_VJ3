using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaDialogueManager : MonoBehaviour, IInteractable
{
    public Conversation _lunasCurrentDialogue;
    public static bool _hasAlreadyTalkedToLuna = false;
    public static bool _lunaDoesntWantToTalk = true;

    bool _isItLunaMainDialogue = true;

    GameManager _gameManagerReference;
    private void Awake()
    {
        _gameManagerReference = FindObjectOfType<GameManager>();
    }

    public void Interact()
    {
        SearchDialogues();
    }

    private void SearchDialogues()
    {
        _hasAlreadyTalkedToLuna = true;

        if (GameManager._currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_lunaDoesntWantToTalk)
            {

                if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_5)
                {
                    if (_isItLunaMainDialogue)
                    {
                        EventManager.NextRequest.Invoke();
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_01"); 
                        _isItLunaMainDialogue = false;
                        GameManager.UpdateConversationLog(2);
                    }
                    else
                    {
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/GF_Dialogues/Luna_GF_Dialogue_01");
                        LunaNoTalkMore();
                    }
                }
            }

            if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {
                _isItLunaMainDialogue = true;

                if (GameManager._currentQuest == FinishedQuest.SPEAKWITHLUNAINRECEPTION)
                {
                    EventManager.NextRequest.Invoke();
                    _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                    GameManager.UpdateConversationLog(3);
                }

            }
        }
        EventManager._ConversationStarts.Invoke(_lunasCurrentDialogue);

    }

    private void LunaNoTalkMore()
    {
        _lunaDoesntWantToTalk = false;
    }

}
