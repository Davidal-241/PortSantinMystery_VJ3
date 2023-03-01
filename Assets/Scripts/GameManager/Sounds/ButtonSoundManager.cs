using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.ButtonSound.AddListener(ButtonSound);
    }

    public void ButtonSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[8];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
