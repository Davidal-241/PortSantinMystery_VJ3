using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCenturion : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        EventManager.InteractueWithCenturionDoors.Invoke();
    }
}
