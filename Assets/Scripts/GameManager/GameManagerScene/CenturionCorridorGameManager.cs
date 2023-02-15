using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenturionCorridorGameManager : GameManager
{
    [SerializeField] Transform comingFromElevatorToCenturionHallTransform;
    protected override void Start()
    {

        if (string.Compare(_previousSceneName, "Vestibulo") == 0)
        {
            _player.transform.position = comingFromElevatorToCenturionHallTransform.position;

            _player.transform.rotation = comingFromElevatorToCenturionHallTransform.rotation;
        }
        if (string.Compare(_previousSceneName, "Pasillo") == 0)
        {
            _player.transform.position = comingFromElevatorToCenturionHallTransform.position;

            _player.transform.rotation = comingFromElevatorToCenturionHallTransform.rotation;
        }
        base.Start();
    }
}
