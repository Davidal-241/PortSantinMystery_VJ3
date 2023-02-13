using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLogical : MonoBehaviour, IInteractable
{
    [SerializeField] int _NextSceneIndex;

    public void Interact()
    {
        CheckTheScene();
    }

    private void CheckTheScene()
    {
        EventManager.SendIndex.Invoke(_NextSceneIndex);
    }

}
