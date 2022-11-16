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

    public static UnityEvent _Talk = new UnityEvent();

    public static UnityEvent _OpenInventory = new UnityEvent();
    public static UnityEvent _CloseInventory = new UnityEvent();

    public static UnityEvent _changeScene = new UnityEvent();

    //public static UnityEvent _StartFeedback = new UnityEvent();
    //public static UnityEvent _StopFeedback = new UnityEvent();


    public static bool _youKnowJorge = false;
    public static bool _youKnowLuna = false;
    public static bool _youKnowCenturion = false;
    public static bool _youKnowPrayer = false;
    public static bool _youKnowDriver= false;
    public static bool _youKnowReviewer = false;
}
