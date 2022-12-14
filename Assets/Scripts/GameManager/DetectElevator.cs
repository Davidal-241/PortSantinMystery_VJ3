using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectElevator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalBools._isCloseToElevator = true;
        }
    }  private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalBools._isCloseToElevator = false;
            EventManager._CloseElevator.Invoke();
            GlobalBools._canSubmit = false;
        }
    }
}
