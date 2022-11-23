using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicVolumen : MonoBehaviour
{
    public Slider _sliderGeneral;/*_sliderMusic, _sliderAmbient;*/

    public float _sliderValue;

    //public AudioSource  _audioListenerMusic, _audioListenerAmbient;

    private void Start()
    {
        _sliderGeneral.value = PlayerPrefs.GetFloat("volumenGeneral", 0.5f);
        //_sliderMusic.value = PlayerPrefs.GetFloat("volumenMusic", 0.5f);
        //_sliderAmbient.value = PlayerPrefs.GetFloat("volumenAmbient", 0.5f);

        AudioListener.volume = _sliderGeneral.value;

        //_audioListenerMusic.volume = _sliderMusic.value;
        //_audioListenerAmbient.volume = _sliderMusic.value;

        
    }

    public void ChangeSlider(float value)
    {

        _sliderValue = value;
        PlayerPrefs.SetFloat("volumenGeneral", _sliderValue);
        AudioListener.volume = _sliderGeneral.value;

    }
}
