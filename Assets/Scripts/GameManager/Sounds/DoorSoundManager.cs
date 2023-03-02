using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.DoorSound.AddListener(DoorSound);
    }

    public void DoorSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[3];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
