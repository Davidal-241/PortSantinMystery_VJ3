using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{

    //public static UnityEvent _cameraFarChurch = new UnityEvent();
    //public static UnityEvent _cameraZoomChurch = new UnityEvent();
    //public static UnityEvent _cameraFarHotel = new UnityEvent();
    //public static UnityEvent _cameraZoomHotel = new UnityEvent();

    public static UnityEvent _ConversationStarts = new UnityEvent();

    public static UnityEvent _EnterInElevator = new UnityEvent();
    public static UnityEvent _CloseElevator = new UnityEvent();

    //public static UnityEvent _InteractueGlasses = new UnityEvent();
    //public static UnityEvent _InteractueBed = new UnityEvent();

    public static UnityEvent _OpenInventory = new UnityEvent();
    public static UnityEvent _CloseInventory = new UnityEvent();
    public static UnityEvent _OpenMenuPause = new UnityEvent();

    public static UnityEvent _changeScene = new UnityEvent();


    public static UnityEvent _CheckNotes = new UnityEvent();
    public static UnityEvent _ChangePageInventory = new UnityEvent();
    public static UnityEvent _ChangePageNotes = new UnityEvent();
    public static UnityEvent _ChangePagePhotos = new UnityEvent();
    public static UnityEvent _ChangePageControlls = new UnityEvent();

    public static UnityEvent _CesarDialoguesEvent = new UnityEvent();

    public static UnityEvent _LunaPositionEvent = new UnityEvent();

    public static UnityEvent _DoorDialogue = new UnityEvent();

    public static UnityEvent DialogueEnded = new UnityEvent();

    //public static UnityEvent _StartFeedback = new UnityEvent();
    //public static UnityEvent _StopFeedback = new UnityEvent();



}
