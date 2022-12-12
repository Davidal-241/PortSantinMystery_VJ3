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
    [SerializeField] string _receptionHotel, _firstFloorHotel, _secondFloorHotel;


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
            GlobalBools._isInSecond = false;
        }

        if (_currentScene.name == _firstFloorHotel)
        {
            GlobalBools._isInReception = false;
            GlobalBools._isInFirstFloor = true;
            GlobalBools._isInSecond = false;

        }

        if (_currentScene.name == _secondFloorHotel)
        {
            GlobalBools._isInReception = false;
            GlobalBools._isInFirstFloor = false;
            GlobalBools._isInSecond = true;
        }
    }
    
}
