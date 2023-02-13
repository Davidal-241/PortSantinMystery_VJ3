using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaFullScree : MonoBehaviour
{
    public Toggle _toggle;

    // Start is called before the first frame update
    void Start()
    {
        EventManager._FullScreen.AddListener(ActiveFullScreen);
    }

   public void ActiveFullScreen(bool fullScreen)
    {
        Screen.fullScreen = fullScreen;
        _toggle.isOn = fullScreen;
    }
}
