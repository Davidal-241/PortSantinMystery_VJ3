using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_Introduction : MonoBehaviour
{
    [SerializeField] private KeyCode _switchSceneKay;
    [SerializeField] private Animator _animator;
    private bool _startTransition;

    void Update()
    {
        if(!_startTransition)
        {
            if (Input.GetKeyDown(_switchSceneKay))
            {
                print("Holi");
                _startTransition = true;
            }
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("Exterior");
    }
}
