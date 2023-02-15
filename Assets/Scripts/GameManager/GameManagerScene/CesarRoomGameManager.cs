using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CesarRoomGameManager : GameManager
{
    [SerializeField] Transform comingFromOutsideCesarRoomTransform;

    protected override void Start()
    {
        if (string.Compare(_previousSceneName, "Pasillo") == 0)
        {
            _player.transform.position = comingFromOutsideCesarRoomTransform.position;

            _player.transform.rotation = comingFromOutsideCesarRoomTransform.rotation;
        }
        base.Start();
    }
}
