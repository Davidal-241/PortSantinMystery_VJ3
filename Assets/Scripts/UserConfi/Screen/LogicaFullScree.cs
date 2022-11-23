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
        if(Screen.fullScreen)
        {
            _toggle.isOn = true;
        }
        else
        {
            _toggle.isOn = false;
        }
    }

   public void ActiveFullScreen(bool screeFull)
    {
        Screen.fullScreen = screeFull;
    }
}
