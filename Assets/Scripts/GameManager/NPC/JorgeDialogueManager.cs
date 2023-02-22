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
        print("JorgeDialogueManager:: " + GameManager._currenStoryParts + " " + GameManager._currentStagesStoryParts + " " + GameManager._currentQuest) ;

        if (GameManager._currenStoryParts == StoryParts.FIRST_PART)
        {
            if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if(GameManager._currentQuest == FinishedQuest.INRECEPTION)
                {
                    if (_isItJorgesMainDialogue)
                    {
                        print("Is main dialogue");
                        _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/N_Dialogues/Jorge_N_Dialogue_01");
                        GameManager.UpdateConversationLog(1);
                        EventManager.NextRequest.Invoke();
                        _isItJorgesMainDialogue = false;
                    }
                }
            }
            else if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                int _randomConversationIndex = Random.Range(0, 2);

                if (_randomConversationIndex == 0)
                {
                    _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_01");

                }
                else if (_randomConversationIndex == 1)
                {
                    _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");

                }
            }

            else if (GameManager._currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                _jorgesCurrentDialogue = Resources.Load<Conversation>("Jorge/GF_Dialogues/Jorge_GF_Dialogue_02");
            }
        }

        EventManager._ConversationStarts.Invoke(_jorgesCurrentDialogue);
    }
}
