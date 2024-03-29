using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.RainSound.AddListener(RainSound);
    }

    public void RainSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[9];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
