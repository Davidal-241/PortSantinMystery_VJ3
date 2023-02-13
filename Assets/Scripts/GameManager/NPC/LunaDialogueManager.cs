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
    }

    public void Interact()
    {
        SearchDialogues();
    }

    private void SearchDialogues()
    {
        _hasAlreadyTalkedToLuna = true;

        if (_gameManagerReference._currenStoryParts == GameManager.StoryParts.FIRST_PART)
        {
            if (!_lunaDoesntWantToTalk)
            {

                if (_gameManagerReference._currentStagesStoryParts == GameManager.StagesStoryParts.STAGE_4)
                {
                    if (_isItLunaMainDialogue)
                    {
                        EventManager.NextRequest.Invoke();
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_01");
                        GameManager.UpdateConversationLog(2);
                    }
                    else
                    {
                        _lunaDoesntWantToTalk = true;
                        _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/GF_Dialogues/Luna_GF_Dialogue_01");
                    }
                }
            }

            if (_gameManagerReference._currentStagesStoryParts == GameManager.StagesStoryParts.STAGE_7)
            {
                _isItLunaMainDialogue = true;

                if (_gameManagerReference._currentRequestCondition == GameManager.RequestCondition.SPOKELUNAINRECEPTION)
                {
                    EventManager.NextRequest.Invoke();
                    _lunasCurrentDialogue = Resources.Load<Conversation>("Luna/N_Dialogues/Luna_N_Dialogue_02");
                    GameManager.UpdateConversationLog(3);
                }

            }
        }
        EventManager._ConversationStarts.Invoke(_lunasCurrentDialogue);

    }

}
