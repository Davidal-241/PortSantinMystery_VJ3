using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        EventManager._GoToMainMenu.AddListener(GoMenuPrincipalMain);
    }
    public void GoMenuPrincipalMain()
    {
        SceneManager.LoadScene(0);
    }
}
