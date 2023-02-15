using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_Introduction : MonoBehaviour
{
    [SerializeField] private KeyCode _switchSceneKay;
    private Animator _animator;
    private bool _startTransition;

    private void Start()
    {
        _startTransition = false;
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(!_startTransition)
        {
            if (Input.GetKeyDown(_switchSceneKay))
            {
                _animator.SetTrigger("Start");
                _startTransition = true;
            }
        }
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("Exterior");
    }
}
