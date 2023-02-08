using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sergioprueba : MonoBehaviour
{
    [SerializeField] private SoundManager _soundManager;
    
    void Start()
    {
        _soundManager.TypeSound();
    }

    
    void Update()
    {
        
    }
}
