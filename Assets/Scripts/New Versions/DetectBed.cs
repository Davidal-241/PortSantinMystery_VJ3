using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBed : MonoBehaviour,IInteractable
{
    public void Interact()
    {

    }

    private void LeaveTheBag()
    {
        ProgressCheck._didYouLeaveTheSuitcase = true;
    }

}
