using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLogical : MonoBehaviour, IInteractable
{
    [SerializeField] int _indexScene;
   
    public void Interact()
    {
        ChangeTheScene();
    }

    private void ChangeTheScene()
    {
        if (ProgressCheck._areWeOutsideTheHotel)
        {
            SceneManager.LoadScene(_indexScene);
        }
        if (ProgressCheck.canYouLeaveThehotel)
        {
            SceneManager.LoadScene(_indexScene);
        }
        else
        {
            ProgressCheck._youTryGoOutside = true;
            EventManager._CesarDialoguesEvent.Invoke();
            ProgressCheck._youTryGoOutside = false;
        }

        if (ProgressCheck._areWeOutsideTheWeRoom)
        {
            ProgressCheck._canYouInteractWithYourDoor = true;
            SceneManager.LoadScene(_indexScene);
        }

        if (ProgressCheck._areWeOutsideTheCenturionRoom)
        {
            SceneManager.LoadScene(_indexScene);
        }

    }
}
