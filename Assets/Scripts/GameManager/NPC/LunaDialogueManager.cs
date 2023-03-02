using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaDialogueManager : MonoBehaviour, IInteractable
{
    public Conversation _lunasCurrentDialogue;
    public static bool _hasAlreadyTalkedToLuna = false;
    public static bool _lunaDoesntWantToTalk = false;

    bool _isItLunaMainDialogue = true;

    GameManager _gameManagerReference;
    private void Awake()
    {
        _gameManagerReference = FindObjectOfType<GameManager>();
        EventManager.LunaInReceptionTalk.AddListener(SearchDialogues);
    }

    public void Interact()
    {
        SearchDialogues();
    }

    private void SearchDialogues()
    {
        print("Luna::SearchDialogues: " + GameManager._currenStoryParts + " - " + GameManager._currentStagesStoryParts + " - " + GameManager._currentQuest);

        _hasAlreadyTalkedToLuna = true;

        if (GameManager._currenStoryParts == StoryParts.FIRST_PART)
        {
            print(_lunaDoesntWantToTalk);

            if (!_lunaDoesntWantToTalk)
            {
                if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_5)
                {
                    if (_isItLunaMainDialogue)
                    {
                        print("main diag");
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_01");
                        EventManager._ConversationStarts.Invoke(_lunasCurrentDialogue);
                        _isItLunaMainDialogue = false;
                        GameManager.UpdateConversationLog(2);
                        EventManager.NextRequest.Invoke();
                    }
                    else
                    {
                        print("alt diag");
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/GF_Dialogues/Luna_GF_Dialogue_01");
                        EventManager._ConversationStarts.Invoke(_lunasCurrentDialogue);
                        LunaNoTalkMore();
                    }
                }
            }

            else if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {
                _isItLunaMainDialogue = true;

                if (GameManager._currentQuest == FinishedQuest.SPEAKWITHLUNAINRECEPTION)
                {
                    print("luna n 2");
                    _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                    EventManager._ConversationStarts.Invoke(_lunasCurrentDialogue);
                    GameManager.UpdateConversationLog(3);
                    EventManager.NextRequest.Invoke();
                }

            }
        }
        

    }

    private void LunaNoTalkMore()
    {
        _lunaDoesntWantToTalk = true;
        print("luna ya no quiere hablar");
    }

}
