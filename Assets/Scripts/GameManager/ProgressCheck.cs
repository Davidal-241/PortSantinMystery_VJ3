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
    public static bool _areWeOutsideTheCenturionRoom;
    public static bool _areWeInReception;

    public static bool _youTryGoOutside;
    public static bool _youTryUseElevator;
    public static bool _youTryUseElevatorDown;

    public static bool _isLunaInTheScene;
    public static bool _spawnLuna;

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
        Scene _currentScene = SceneManager.GetActiveScene();


        if (_currentScene.name != _sceneName[1])
        {
            _areWeOutsideTheCenturionRoom = false;
        }
       if(_currentScene.name == _sceneName[1])
        {
            _areWeOutsideTheCenturionRoom = true;
        }

       if(_currentScene.name == _sceneName[3])
        {
            _areWeInReception = true;
        }
        else
        {
            _areWeInReception = false;
        }

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
                    if (_youTryGoOutside)
                    {
                        EventManager._CesarDialoguesEvent.Invoke();
                        _youTryGoOutside = false;
                    }
                    if (_youTryUseElevator)
                    {
                        EventManager._CesarDialoguesEvent.Invoke();
                        _youTryUseElevator = false;
                    }
                }
                else
                {
                    _canUseElevator = true;
                    _canUseElevatorToGoDown = false;
                }

                if (_youTryGoOutside)
                {
                    EventManager._CesarDialoguesEvent.Invoke();
                    _youTryGoOutside = false;
                }

                if (!_canUseElevatorToGoDown)
                {
                    if (_youTryUseElevatorDown)
                    {
                        EventManager._CesarDialoguesEvent.Invoke();
                        _youTryUseElevatorDown = false;
                    }

                }
                

                if (_areWeInTheStage3)
                {
                    if (_currentScene.name == _sceneName[0])
                    {
                        _areWeOutsideTheWeRoom = true;
                    }
                    else
                    {
                        _areWeOutsideTheWeRoom = false;
                    }

                    _canUseElevator = false;

                    if (_youTryUseElevator)
                    {

                        if (!_didYouLeaveTheSuitcase)
                        {
                           
                            EventManager._CesarDialoguesEvent.Invoke();
                        }
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
                            _spawnLuna = true;
                        }
                    }
                    else
                    {
                        _spawnLuna = false;
                    }

                    if (!GlobalBools._isknowLuna)
                    {
                        if (_youTryUseElevator)
                        {

                            EventManager._CesarDialoguesEvent.Invoke();
                        }
                    }
                    else
                    {
                        _canUseElevator = true;
                        _canUseElevatorToGoDown = true;
                    }

                    if (!_canYouExit)
                    {
                        if (_youTryGoOutside)
                        {
                            EventManager._CesarDialoguesEvent.Invoke();
                        }
                    }

                    if (!GlobalBools._isknowCenturion)
                    {
                        if(_currentScene.name == _sceneName[1])
                        {
                            _canUseElevator = false;
                            _areWeInTheStage5 = false;
                            _areWeInTheStage6 = true;
                            _areWeOutsideTheCenturionRoom = true;
                        }
                    }
                }

                if (_areWeInTheStage6)
                {
                    if (!GlobalBools._isknowCenturion)
                    {
                        if (_youTryUseElevator)
                        {
                            EventManager._CesarDialoguesEvent.Invoke();
                        }
                    }
                    if (GlobalBools._isknowCenturion)
                    {
                        _canUseElevator = true;
                    }

                    
                    if (!_isLunaInTheScene)
                    {

                        if (_currentScene.name == _sceneName[2])
                        {
                            EventManager._LunaPositionEvent.Invoke();
                            
                        }
                    }

                    if (_isLunaInTheScene)
                    {
                        if (!_canYouExit)
                        {

                            if (_youTryGoOutside)
                            {
                                EventManager._DoorDialogue.Invoke();
                                _areWeInTheThirdPart = true;
                            }
                        }
                    }

                    
                }
            }
        }

    }
}
