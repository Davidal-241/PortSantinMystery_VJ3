using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField]PlayList _clip;
    AudioClip _currentClip;
    [SerializeField] int _index;
    [SerializeField] bool _isntPlayForUse;

    private void Start()
    {
        //_currentClip = _clip._sounds[_index];
        _audioSource = GetComponent<AudioSource>();
        ElevatorSound();
    }

    private void Update()
    {
        if (_isntPlayForUse)
        {
            _audioSource.clip = _currentClip;
            _audioSource.Play();
        }
    }

    public void ElevatorSound()
    {
        _currentClip = _clip._sounds[0];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void PagSound()
    {
        _currentClip = _clip._sounds[1];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void WritingSound()
    {
        _currentClip = _clip._sounds[2];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void DoorSound()
    {
        _currentClip = _clip._sounds[3];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void WalkingSound()
    {
        _currentClip = _clip._sounds[4];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void ThunderSound()
    {
        _currentClip = _clip._sounds[5];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void TypeSound()
    {
        _currentClip = _clip._sounds[6];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void TypingSound()
    {
        _currentClip = _clip._sounds[7];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void ButtonSound()
    {
        _currentClip = _clip._sounds[8];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
