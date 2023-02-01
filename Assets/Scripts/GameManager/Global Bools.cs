using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalBools 
{
    //Si esta en el rango del jugador un NPC este se activara. Permitiendo que el jugador pueda interactuar con el npc//
    public static bool _isTalking = false;

    //Maneja el flujo de las conversaciones
    public static bool _nextLineActive = false;
    public static bool _isDialoguesLastLine = false;

  
    public static bool _playerCanMove = false;


    //Bool manejo inventario
    public static bool _isOpenInventory = false;

    //Bool manejo Elevador

    public static bool _isElevatorUIActive = false;
    public static bool _isInReception = false;
    public static bool _isInFirstFloor = false;
    public static bool _isInBasement = false;

    //Bool manejo UINavigateLogic

    public static bool _isInventoryActive = false;
    public static bool _isMenuPauseActive = false;

    //Objetos que son interactuables

    public static bool _isCloseToBed = false;
    public static bool _isCloseToGlasses = false;


}
