using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{
    private GameObject musicPrefab;

    void Start()
    {
        musicPrefab = this.gameObject;
    }

    
    void Update()
    {
        DontDestroyOnLoad(musicPrefab);
    }

    
}
