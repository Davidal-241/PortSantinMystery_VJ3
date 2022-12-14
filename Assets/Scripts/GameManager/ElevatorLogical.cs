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
      

        _currentScene = SceneManager.GetActiveScene();

        if(_currentScene.name == _receptionHotel)
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

        if (_currentScene.name == _secondFloorHotel)
        {
            GlobalBools._isInReception = false;
            GlobalBools._isInFirstFloor = false;
            GlobalBools._isInSecondFloor = true;
        }
    }

    public void GoReception()
    {
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
