using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.ThunderSound.AddListener(ThunderSound);
    }

    public void ThunderSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[5];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
