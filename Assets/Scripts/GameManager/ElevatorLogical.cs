using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;

public class ElevatorLogical : MonoBehaviour
{
    public string _receptionHotel, _firstFloorHotel, _secondFloorHotel;


    void Start()
    {
        EventManager._EnterInElevator.AddListener(UseElevator);
    }

    public void UseElevator()
    {
        Scene _currentScene;

        ProgressCheck._youTryUseElevator = true;

        _currentScene = SceneManager.GetActiveScene();

        if (ProgressCheck._canUseElevator)
        {

            if (_currentScene.name == _receptionHotel)
            {
                GlobalBools._isInReception = true;
                GlobalBools._isInFirstFloor = false;
                GlobalBools._isInSecondFloor = false;
            }

            if (_currentScene.name == _firstFloorHotel)
            {
                GlobalBools._isInReception = false;
                GlobalBools._isInFirstFloor = true;
                GlobalBools._isInSecondFloor = false;

            }

            if (ProgressCheck._canUseElevatorToGoDown)
            {
                if (_currentScene.name == _secondFloorHotel)

                {
                    GlobalBools._isInReception = false;
                    GlobalBools._isInFirstFloor = false;
                    GlobalBools._isInSecondFloor = true;
                }
            }
            else
            {
                ProgressCheck._youTryUseElevatorDown = true;
            }
        }
    }

    public void GoReception()
    {if(!GlobalBools._isInReception)
        SceneManager.LoadScene(_receptionHotel);
    }
    public void GoFirstFloor()
    {
        SceneManager.LoadScene(_firstFloorHotel);

    }
    public void GoSecondFloor()
    {
        SceneManager.LoadScene(_secondFloorHotel);

    }

}
