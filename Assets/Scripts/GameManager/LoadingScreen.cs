using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
   

    private void Start()
    {
        EventManager.Load.AddListener(LoadScenne);
    }

    public void LoadScenne(string sceneToLoad)
    {
        StartCoroutine(LoadSceneAsync(sceneToLoad));
    }


    IEnumerator LoadSceneAsync(string sceneName)
    {

        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);

        while (!async.isDone)
        {
           

             yield return null;

        }

    }

}
