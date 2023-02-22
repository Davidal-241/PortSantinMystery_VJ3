using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.ElevatorSound.AddListener(ElevatorSound);
    }

    public void ElevatorSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[0];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
