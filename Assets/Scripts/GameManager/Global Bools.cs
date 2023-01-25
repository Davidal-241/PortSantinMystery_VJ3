using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalBools 
{
    // Se debe activar cuando se entre en el rango del NPC/Objecto/Puerta//
    //public static bool _activeFeedback = false;

    //Si esta en el rango del jugador un NPC este se activara. Permitiendo que el jugador pueda interactuar con el npc//
    public static bool _canTalk = false;
    public static bool _isTalking = false;

    //Maneja el flujo de las conversaciones
    public static bool _nextLineActive = false;
    public static bool _isDialoguesLastLine = false;

    //NPCS
        // Conocer a un npc
    public static bool _isknowDriver = false;
    public static bool _isknowReviewer = false;
    public static bool _isknowLuna = false;
    public static bool _isknowCenturion = false;
    public static bool _hasAlreadyTalkedToJorge = false;
    public static bool _isknowPrayer = false;
    //Hablando con el npc
    public static bool _playerCanMove = false;
    public static bool _isdriverTalking = false;
    public static bool _isreviewerTalking = false;
    public static bool _isCloseToLuna = false;
    public static bool _isCloseToCenturion = false;
    public static bool _isCloseToJorge = false;
    public static bool _isprayerTalking = false;

    public static bool _cantTalkLuna;
        //Tienen mas conversación?
    public static bool _canJorgeTalkMore = false;
    public static bool _canCenturionTalkMore = false;
    public static bool _canLunaTalkMore = false;




    public static bool _isWaitingForInteractue = false;
    

    //Bool manejo Puerta
    public static bool _canOpenDoor = false;
    //Bool manejo inventario
    public static bool _isOpenInventory = false;
    //Bool manejo sprint
    public static bool _isRunning = false;

    //public static bool _DevicePreIsKeyBoard = true;

    //Bool manejo Elevador
    public static bool _isCloseToElevator = false;
    public static bool _isInReception = true;
    public static bool _isInFirstFloor = false;
    public static bool _isInSecondFloor = false;

    //Bool manejo UINavigateLogic

    public static bool _isInNotesPanel = false;
    public static bool _isInventoryActive = false;
    public static bool _canSubmit = false;
    public static bool _isMenuPauseActive = false;

    //Objetos que son interactuables

    public static bool _isCloseToBed = false;
    public static bool _isCloseToGlasses = false;


}
