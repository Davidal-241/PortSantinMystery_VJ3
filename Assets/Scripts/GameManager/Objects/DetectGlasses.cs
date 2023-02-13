using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGlasses : MonoBehaviour, IInteractable
{
    public Conversation _cesarsCurrentDialogue;

    public void Interact()
    {
        GlassesInTheBed();
    }
  
    private void GlassesInTheBed()
    {

        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_04");
        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);

    }
}
