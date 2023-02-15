using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallGameManager : GameManager
{
    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] Transform _LunaSpawnPoint;

    [SerializeField] Transform comingFromElevatorToHallTransform;
    [SerializeField] Transform comingFromInsideCesarRoomTransform;


    protected override void Start()
    {
        if (string.Compare(_previousSceneName, "Habitacion_Cesar") == 0)
        {
            _player.transform.position = comingFromInsideCesarRoomTransform.position;

            _player.transform.rotation = comingFromInsideCesarRoomTransform.rotation;
        }
        else if (string.Compare(_previousSceneName, "Pasillo Centurion") == 0)
        {
            _player.transform.position = comingFromElevatorToHallTransform.position;
            _player.transform.rotation = comingFromElevatorToHallTransform.rotation;

        }
        else if (string.Compare(_previousSceneName, "Vestibulo") == 0)
        {
            _player.transform.position = comingFromElevatorToHallTransform.position;


            _player.transform.rotation = comingFromElevatorToHallTransform.rotation;
        }

        base.Start();

        if (_currentQuest == RequestCondition.SPOKELUNA)
        {
            if (_currenStoryParts == StoryParts.FIRST_PART)
            {
                if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
                {
                    Instantiate(_lunaPrefab, _LunaSpawnPoint);
                }
            }
        }
    }
}
