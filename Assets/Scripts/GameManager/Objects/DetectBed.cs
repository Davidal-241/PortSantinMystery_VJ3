using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBed : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        LeaveTheBag();
    }

    private void LeaveTheBag()
    {
        EventManager.NextRequest.Invoke();
    }

}
