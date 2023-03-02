using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] PlayList _clip;
    AudioClip _currentClip;

    private float _minPitchSpeed, _maxPitchSpeed;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _minPitchSpeed = 0.5f;
        _maxPitchSpeed = 1.5f;
        //EventManager.WalkingSound.AddListener(StepSound);
    }

    public void WalkingSound()
    {
        _currentClip = _clip._sounds[4];
        _audioSource.clip = _currentClip;
        _audioSource.Play();
        _audioSource.pitch = Random.Range(_minPitchSpeed, _maxPitchSpeed);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _audioSource.enabled = true;
        }
        else
        {
            _audioSource.enabled = false;
        }
    }
}
