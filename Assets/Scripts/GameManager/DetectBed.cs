using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalBools._isCloseToBed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalBools._isCloseToBed = false;
            
        }
    }
}
