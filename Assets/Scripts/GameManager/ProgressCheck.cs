using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressCheck : MonoBehaviour
{
    public static bool _areWeInTheIntro;
    public static bool _areWeInTheSecondPart;
    public static bool _areWeInTheThirdPart;

    public static bool _canUseElevator;
    public static bool _canUseElevatorToGoDown;
    public static bool _didYouLeaveTheSuitcase;
    public static bool _didYouExitTheRoom;
    public static bool _canYouInteractWithYourDoor;
    public static bool _canYouInteractWithYourBed;

    public static bool _didYouInteractWithTheGlasses;
    public static bool _canYouExit = false;

    public static bool _areWeInTheStage1;
    public static bool _areWeInTheStage2;
    public static bool _areWeInTheStage3;
    public static bool _areWeInTheStage4;
    public static bool _areWeInTheStage5;
    public static bool _areWeInTheStage6;

    public static bool _canWalkForTheScene;
    public static bool _areWeInTheHotel;
    public static bool _areWeOutsideTheWeRoom;

    public static bool _youTryGoOutside;

    public static bool _isLunaInTheScene;

    public string[] _sceneName;

    private void Start()
    {
        GameFlow();
    }

    private void Update()
    {
        GameFlow();
    }

    public void GameFlow()
    {

        if (_areWeInTheSecondPart)
        {
            if (_areWeInTheStage1)
            {
                _canWalkForTheScene = false;
                _didYouLeaveTheSuitcase = false;
            }

            if (_areWeInTheHotel)
            {
                _areWeInTheStage1 = false;
                _areWeInTheStage2 = true;
            }

            if (_areWeInTheStage2)
            {
                if (!GlobalBools._isknowJorge)
                {
                    _canUseElevator = false;
                    EventManager._CesarDialoguesEvent.Invoke();
                }
                else
                {
                    _canUseElevator = true;
                    _canUseElevatorToGoDown = false;
                }

                if (!_canUseElevatorToGoDown)
                {
                    EventManager._CesarDialoguesEvent.Invoke();

                }
                //En el elevador definir el cambio

                if (_areWeInTheStage3)
                {
                    if (!_didYouLeaveTheSuitcase)
                    {
                        _canUseElevator = false;
                        EventManager._CesarDialoguesEvent.Invoke();
                    }
                    if (_canYouInteractWithYourDoor)
                    {
                        _areWeInTheStage3 = false;
                        _areWeInTheStage4 = true;
                    }
                }

                if (_areWeInTheStage4)
                {
                    // hacer script cama y gafas

                    if (_didYouLeaveTheSuitcase)
                    {
                        _canYouInteractWithYourBed = false;
                    }
                    if (_didYouInteractWithTheGlasses)
                    {
                        EventManager._CesarDialoguesEvent.Invoke();
                        _didYouInteractWithTheGlasses = false;
                    }
                    if (_didYouExitTheRoom)
                    {
                        _areWeInTheStage5 = true;
                    }
                }

                if (_areWeInTheStage5)
                {
                    Scene _currentScene = SceneManager.GetActiveScene();

                    if(_currentScene.name == _sceneName[0])
                    {
                        _areWeOutsideTheWeRoom = true;
                    }
                    else
                    {
                        _areWeOutsideTheWeRoom = false;
                    }
                    
                    //Hacer script de luna
                    if(!_isLunaInTheScene)
                    {
                        if (_areWeOutsideTheWeRoom)
                        {
                            EventManager._LunaPositionEvent.Invoke();
                        }
                    }

                    if (!GlobalBools._isknowLuna)
                    {
                        EventManager._CesarDialoguesEvent.Invoke();
                    }
                    else
                    {
                        _canUseElevator = true;
                        _canUseElevatorToGoDown = true;
                    }

                    if (!_canYouExit)
                    {
                        EventManager._CesarDialoguesEvent.Invoke();
                    }

                    if (!GlobalBools._isknowCenturion)
                    {
                        if(_currentScene.name == _sceneName[1])
                        {
                            _canUseElevator = false;
                            _areWeInTheStage5 = false;
                            _areWeInTheStage6 = true;
                        }
                    }
                    else
                    {
                        _canUseElevator = true;
                    }

                    if (_youTryGoOutside)
                    {
                        _canYouExit = true;
                    }


                }
            }
        }

    }
}
