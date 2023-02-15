using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionGameManager : GameManager
{
    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] Transform _LunaSpawnPoint;
    [SerializeField] Transform comingFromElevatorTransform;
    [SerializeField] Transform comingFromOutsideTransform;


    protected override void Start()
    {
        if (
                string.Compare(_previousSceneName, "Pasillo") == 0
                ||
                string.Compare(_previousSceneName, "Pasillo Centurion") == 0
            )
        {
            _player.transform.position = comingFromElevatorTransform.position;

            _player.transform.rotation = comingFromElevatorTransform.rotation;


        }
        else if (string.Compare(_previousSceneName, "Exterior") == 0)
        {
            _player.transform.position = comingFromOutsideTransform.position;

            _player.transform.rotation = comingFromOutsideTransform.rotation;
        }

        base.Start();

        if (_currentQuest == RequestCondition.SPEAKWITHLUNAINRECEPTION)
        {
            if (_currenStoryParts == StoryParts.FIRST_PART)
            {
                if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
                {

                    Instantiate(_lunaPrefab, _LunaSpawnPoint);
                }
            }
        }
    }



}
