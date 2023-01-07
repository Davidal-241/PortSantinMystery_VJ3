using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGlasses : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalBools._isCloseToGlasses = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalBools._isCloseToGlasses = false;
           
            
        }
    }
}
