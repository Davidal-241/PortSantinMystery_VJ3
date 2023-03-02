using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraStop : MonoBehaviour
{
    [SerializeField] Camera _main;
    bool _islocked = false;


    private void Start()
    {
        _main = Camera.main;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

          
                _main.GetComponent<CinemachineVirtualCamera>().enabled = false;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

           
                _main.GetComponent<CinemachineVirtualCamera>().enabled = true;
           
        }
    }
}
