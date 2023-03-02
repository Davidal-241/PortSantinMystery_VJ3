using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.PickUpSound.AddListener(PickUpSound);
    }

    public void PickUpSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[1];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
