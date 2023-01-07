using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaSpawnLogical : MonoBehaviour
{
    [SerializeField] GameObject _lunaPrefab;
    GameObject _existLunaInTheScene;
    [SerializeField] Transform _LunaSpawnPoint;
    private void Start()
    {
        EventManager._LunaPositionEvent.AddListener(NewPositionInTheScene);
        _existLunaInTheScene = GameObject.FindGameObjectWithTag("Luna");
        NewPositionInTheScene();
    }
    public void NewPositionInTheScene()
    {
        if(_existLunaInTheScene != null)
        {
            Destroy(_existLunaInTheScene);
        }

        if (ProgressCheck._areWeOutsideTheWeRoom)
        {
            if (ProgressCheck._areWeInTheSecondPart)
            {
                if (ProgressCheck._areWeInTheStage5)
                {
                    Instantiate(_lunaPrefab, _LunaSpawnPoint);
                }
            }
        }

        if (ProgressCheck._areWeInReception)
        {
            if (ProgressCheck._areWeInTheSecondPart)
            {
                if (ProgressCheck._areWeInTheStage6)
                {
                    Instantiate(_lunaPrefab, _LunaSpawnPoint);
                }
            }
        }
    }
}
