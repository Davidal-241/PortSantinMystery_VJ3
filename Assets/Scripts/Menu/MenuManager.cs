using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject _exitMenu;

    public void Play()
    {
        SceneManager.LoadScene("Introduccion");
    }

    public void Credits()
    {

    }

    public void OpenExitMenu()
    {
        _exitMenu.SetActive(true);
    }
    public void CloseExitMenu()
    {
        _exitMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

   
}
