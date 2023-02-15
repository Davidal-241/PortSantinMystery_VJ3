using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetGameManager : GameManager
{
    [SerializeField] Transform comingFromInsideToStreetTransform;

    protected override void Start()
    {
        if (string.Compare(_previousSceneName, "Vestibulo") == 0)
        {
            _player.transform.position = comingFromInsideToStreetTransform.position;

            _player.transform.rotation = comingFromInsideToStreetTransform.rotation;
        }
        base.Start();


    }
}
