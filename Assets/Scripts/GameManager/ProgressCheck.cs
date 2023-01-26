using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressCheck : MonoBehaviour
{
    public static bool _areWeInTheIntro = false;
    public static bool _areWeInTheSecondPart = true;
    public static bool _areWeInTheThirdPart = false;

    public static bool _canUseElevator = false;
    public static bool _canUseElevatorToGoDown = false;
    public static bool _didYouLeaveTheSuitcase = false;
    public static bool _didYouExitTheRoom = false;
    public static bool _canYouInteractWithYourDoor = false;
    public static bool _canYouInteractWithYourBed = false;

    public static bool _didYouInteractWithTheGlasses = false;
    public static bool cantYouLeaveThehotel = false;

    public static bool _areWeInTheStage1 = false;
    public static bool _areWeInTheStage2 = true;
    public static bool _areWeInTheStage3 = false;
    public static bool _areWeInTheStage4 = false;
    public static bool _areWeInTheStage5 = false;
    public static bool _areWeInTheStage6 = false;

    public static bool _canWalkForTheScene = false;
    public static bool _areWeInTheHotel = false;
    public static bool _areWeOutsideTheWeRoom = false;
    public static bool _areWeOutsideTheCenturionRoom = false;
    public static bool _areWeInReception = true;

    public static bool _youTryGoOutside = false;
    public static bool _youTryUseElevator = false;
    public static bool _youTryUseElevatorDown = false;

    public static bool _isLunaInTheScene = false;
    public static bool _spawnLuna = false;

    public static bool _finishMainDialogueJorge = false;

    public string[] _sceneName;

    private void Start()
    {
        GameFlow();
    }

    private void Update()
    {
        GameFlow();

        if (_finishMainDialogueJorge)
        {
 
            GlobalBools._isItJorgesMainDialogue = true;
        }
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

            if (_areWeInReception)
            {
                _areWeInTheStage1 = false;
                _areWeInTheStage2 = true;
            }

            if (_areWeInTheStage2)
            {
                if (!GlobalBools._hasAlreadyTalkedToJorge)
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

                    if (!GlobalBools._hasAlreadyTalkedToLuna)
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

                    if (!cantYouLeaveThehotel)
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
                        if (!cantYouLeaveThehotel)
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
