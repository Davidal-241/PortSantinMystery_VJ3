using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public static class EventManager 
{

    public static UnityEvent _EnterInElevator = new UnityEvent();
    public static UnityEvent _CloseElevator = new UnityEvent();

    //public static UnityEvent _InteractueGlasses = new UnityEvent();
    //public static UnityEvent _InteractueBed = new UnityEvent();

    public static UnityEvent _OpenInventory = new UnityEvent();
    public static UnityEvent<InputAction.CallbackContext> _CloseInventory = new UnityEvent<InputAction.CallbackContext>();
    public static UnityEvent _OpenMenuPause = new UnityEvent();

    public static UnityEvent _changeScene = new UnityEvent();

    public static UnityEvent _CesarDialoguesEvent = new UnityEvent();

    public static UnityEvent _LunaPositionEvent = new UnityEvent();

    public static UnityEvent _DoorDialogue = new UnityEvent();

    public static UnityEvent DialogueEnded = new UnityEvent();

    //public static UnityEvent _StartFeedback = new UnityEvent();
    //public static UnityEvent _StopFeedback = new UnityEvent();


    //Nuevo Sistema de implementación//

    public static UnityEvent _InteractionStart = new UnityEvent();
    public static UnityEvent<Conversation> _ConversationStarts = new UnityEvent<Conversation>();


}
