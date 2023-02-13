using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUIElevator : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        EventManager._CheckConveElevator.Invoke();
    }
}
