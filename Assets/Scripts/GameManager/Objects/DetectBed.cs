using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBed : MonoBehaviour,IInteractable
{
   [SerializeField] GameObject _cesarMaleta;
    [SerializeField] GameObject _cesarSinMaleta;
    [SerializeField] GameObject _suitcaseInRoom;
    static bool _isSuitcaseInTheRoom = false;

    private void Awake()
    {
        _cesarMaleta = GameObject.Find("Cesar");
        _cesarSinMaleta = GameObject.Find("Cesar_NoMaleta");
        _suitcaseInRoom = GameObject.Find("Maleta");
    }

    private void Start()
    {

        if (!_isSuitcaseInTheRoom)
        {
            _suitcaseInRoom.SetActive(false);
            _cesarSinMaleta.SetActive(false);
        }
    }


    public void Interact()
    {
        if (!_isSuitcaseInTheRoom)
        {

            LeaveTheBag();
        }
    }

    private void LeaveTheBag()
    {
        _isSuitcaseInTheRoom = true;
        _cesarMaleta.SetActive(false);
        _cesarSinMaleta.SetActive(true);
        _suitcaseInRoom.SetActive(true);

        GameManager._isntHandFree = false;

        Debug.Log("This: " + 10);
        EventManager.NextRequest.Invoke();
    }

}
