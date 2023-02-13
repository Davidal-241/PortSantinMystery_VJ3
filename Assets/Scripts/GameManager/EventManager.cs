using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


public static class EventManager 
{
    //Class
    public class UserActionEvent : UnityEvent<UserActions> { };


    //Events




    public static UnityEvent _OpenInventory = new UnityEvent();

    public static UnityEvent<InputAction.CallbackContext> _CloseInventory = new UnityEvent<InputAction.CallbackContext>();

    public static UnityEvent _OpenMenuPause = new UnityEvent();

    public static UnityEvent _CesarDialoguesEvent = new UnityEvent();

    public static UnityEvent _LunaPositionEvent = new UnityEvent();

    public static UnityEvent _DoorDialogue = new UnityEvent();

    public static UnityEvent _DialogueEnded = new UnityEvent();

    public static UnityEvent _GoToMainMenu = new UnityEvent();

    public static UnityEvent<bool> _FullScreen = new UnityEvent<bool>();
    public static UnityEvent<float> _VolumenValue = new UnityEvent<float>();

    //Nuevo Sistema de implementación//

    public static UnityEvent _InteractionStart = new UnityEvent();
    public static UnityEvent<Conversation> _ConversationStarts = new UnityEvent<Conversation>();



    public static UnityEvent _CheckConveElevator = new UnityEvent();
    public static UnityEvent _UseElevator = new UnityEvent();
    public static UnityEvent<int> _ChangeScene = new UnityEvent<int>();



    public static UserActionEvent _InputSet = new UserActionEvent();

    public static UnityEvent ConvesationStarts = new UnityEvent();
    public static UnityEvent ConvesationEnds = new UnityEvent();

    public static UnityEvent UIOn = new UnityEvent();
    public static UnityEvent UIOff = new UnityEvent();

    public static UnityEvent UserMenuOn = new UnityEvent();
    public static UnityEvent UserMenuOff = new UnityEvent();

    public static UnityEvent<int> SendIndex = new UnityEvent<int>();

    public static UnityEvent SpokeNPCRequest = new UnityEvent();
}
