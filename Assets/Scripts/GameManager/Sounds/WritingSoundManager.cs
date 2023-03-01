using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WritingSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        EventManager.WritingSound.AddListener(WritingSound);
    }

    public void WritingSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[2];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
