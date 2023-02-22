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


    private float _minPitchSpeed, _maxPitchSpeed;

    private void Awake()
    {
        //_currentClip = _clip._sounds[_index];
        _audioSource = GetComponent<AudioSource>();
        _minPitchSpeed = 0.5f;
        _maxPitchSpeed = 1.5f;
        
        //TypeSound();
    }

    private void Update()
    {
        //if (_audioSource.isPlaying == false)
        //{
        //    _currentClip = _clip._sounds[9];
        //    _audioSource.clip = _currentClip;
        //    _audioSource.Play();
        //}
    }

    public void ElevatorSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[0];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void PagSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[1];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void WritingSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[2];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void DoorSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[3];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void WalkingSound()
    {
        _currentClip = _clip._sounds[4];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
        _audioSource.pitch = Random.Range(_minPitchSpeed, _maxPitchSpeed);
    }

    public void ThunderSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[5];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void TypeSound()
    {
        _currentClip = _clip._sounds[Random.Range(6,8)];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
        _audioSource.pitch = Random.Range(_minPitchSpeed, _maxPitchSpeed);
    }

    //public void TypingSound()
    //{
    //    _currentClip = _clip._sounds[7];
    //    _audioSource.clip = _currentClip;
    //    _audioSource.Play();
    //}

    public void ButtonSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[8];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void RainSound()
    {
        _audioSource.pitch = 1;
        _currentClip = _clip._sounds[9];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
