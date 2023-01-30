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
        _audioSource.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_isntPlayForUse)
        {
            _audioSource.clip = _currentClip;
            _audioSource.Play();
        }
    }

    public void WalkingSound()
    {
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }

    public void DoorSound()
    {
        _audioSource.clip = _currentClip;
        _audioSource.Play();
    }
}
