using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenturionDialogueManager : MonoBehaviour, IInteractable
{
    public Conversation _centurionsCurrentDialogue;
    public static bool _hasAlreadyTalkedToCenturion = false;

    bool _isItCenturionsMainDialogue = true;

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
       _hasAlreadyTalkedToCenturion = true;

        if (_gameManagerReference._currenStoryParts == GameManager.StoryParts.FIRST_PART)
        {
            if (_gameManagerReference._currentStagesStoryParts == GameManager.StagesStoryParts.STAGE_6)
            {
                if (_isItCenturionsMainDialogue)
                {
                    _centurionsCurrentDialogue = Resources.Load<Conversation>("Centurion/N_Dialogues/Centurion_N_Dialogue_01");
                    _isItCenturionsMainDialogue = false;
                    EventManager.SpokeNPCRequest.Invoke();

                }
              
            }

            if(!_isItCenturionsMainDialogue)
            {
                _centurionsCurrentDialogue = Resources.Load<Conversation>("Centurion/GF_Dialogues/Centurion_GF_Dialogue_01");
            }
        }
        EventManager._ConversationStarts.Invoke(_centurionsCurrentDialogue);

    }


}
