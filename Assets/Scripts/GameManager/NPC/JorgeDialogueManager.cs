using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeDialogueManager : MonoBehaviour, IInteractable
{
   public Conversation _jorgesCurrentDialogue;
   public static bool _hasAlreadyTalkedToJorge = false;

    bool _isItJorgesMainDialogue = true;

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
        _hasAlreadyTalkedToJorge = true;

        if (GameManager._currenStoryParts == StoryParts.FIRST_PART)
        {
            if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if(GameManager._currentQuest == FinishedQuest.INRECEPTION)
                {
                    if (_isItJorgesMainDialogue)
                    {
                        _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/N_Dialogues/Jorge_N_Dialogue_01");
                        GameManager.UpdateConversationLog(1);
                        Debug.Log("This: " + 7);
                        EventManager.NextRequest.Invoke();
                        _isItJorgesMainDialogue = false; EventManager._ConversationStarts.Invoke(_jorgesCurrentDialogue);
                    }
                }
            }
            else if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if(GameManager._currentQuest == FinishedQuest.SPOKEJORGE)
                {

                int _randomConversationIndex = Random.Range(0, 2);

                if (_randomConversationIndex == 0)
                {
                    _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_01");
                        EventManager._ConversationStarts.Invoke(_jorgesCurrentDialogue);
                    }
                else if (_randomConversationIndex == 1)
                {
                    _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
                        EventManager._ConversationStarts.Invoke(_jorgesCurrentDialogue);
                    }
                }
            }

            else if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
        EventManager._ConversationStarts.Invoke(_jorgesCurrentDialogue);
            }
        }

    }
}
