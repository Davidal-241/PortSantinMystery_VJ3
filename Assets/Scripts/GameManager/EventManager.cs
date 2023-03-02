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
    public static UnityEvent<string> _ChangeScene = new UnityEvent<string>();


    public static UnityEvent<string> Load = new UnityEvent<string>();



    public static UserActionEvent _InputSet = new UserActionEvent();

    public static UnityEvent ConvesationStarts = new UnityEvent();
    public static UnityEvent ConvesationEnds = new UnityEvent();

    public static UnityEvent UIOn = new UnityEvent();
    public static UnityEvent UIOff = new UnityEvent();

    public static UnityEvent UserMenuOn = new UnityEvent();
    public static UnityEvent UserMenuOff = new UnityEvent();

    public static UnityEvent<string> SendIndex = new UnityEvent<string>();

    public static UnityEvent NextRequest = new UnityEvent();

    public static UnityEvent enterInSubTab = new UnityEvent();

    public static UnityEvent InteractueWithCenturionDoors = new UnityEvent();

    public static UnityEvent LunaInReceptionTalk = new UnityEvent();

    public static UnityEvent CloseUIEle = new UnityEvent();


    //sounds

    public static UnityEvent CharacterTyped = new UnityEvent();
    public static UnityEvent ElevatorSound = new UnityEvent();
    public static UnityEvent PagSound = new UnityEvent();
    public static UnityEvent WritingSound = new UnityEvent();
    public static UnityEvent DoorSound = new UnityEvent();
    public static UnityEvent ThunderSound = new UnityEvent();
    public static UnityEvent ButtonSound = new UnityEvent();
    public static UnityEvent RainSound = new UnityEvent();
    public static UnityEvent WalkingSound = new UnityEvent();
    public static UnityEvent TypeSound = new UnityEvent();
    public static UnityEvent PickUpSound = new UnityEvent();
}
