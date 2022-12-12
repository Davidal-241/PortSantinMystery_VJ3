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
    }
}
