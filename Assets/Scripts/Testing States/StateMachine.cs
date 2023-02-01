using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour, IState
{
    #region"Enums"
    protected enum StoryParts
    {

        INTRODUCTION,
        FIRST_PART,
        SECOND_PART

    }

    protected enum StagesStoryParts
    {

        STAGE_1,
        STAGE_2,
        STAGE_3,
        STAGE_4,
        STAGE_5,
        STAGE_6

    }

    protected enum RequestCondition
    {
        OUTSIDETHEHOTEL,
        INRECEPTION,
        SPOKEJORGE,
        OUTSIDETHEROOM,
        LETTHESUICASE,
        SPOKELUNA

    }
    #endregion


    #region"References"

    StoryParts _currenStoryParts;
    StagesStoryParts _currentStagesStoryParts;
    RequestCondition _currentRequestCondition;

    //Este int controla el Switch//

    int _switchIndex = 0;

    #endregion

    private void Awake()
    {
        _currenStoryParts = StoryParts.INTRODUCTION;
        _currentStagesStoryParts = StagesStoryParts.STAGE_1;
        _currentRequestCondition = RequestCondition.OUTSIDETHEHOTEL;
    }


    private void Start()
    {
        GameFlow();
    }

    #region"Introduction"
    private void Introduction()
    {
        if(_currenStoryParts == StoryParts.INTRODUCTION)
        {
            if(_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if(_currentRequestCondition == RequestCondition.INRECEPTION)
                {
                    _currenStoryParts = StoryParts.FIRST_PART;
                    _currentStagesStoryParts = StagesStoryParts.STAGE_1;
                    _currentRequestCondition = RequestCondition.SPOKEJORGE;
                    _switchIndex++;
                }
                else
                {
                    print("No has cumplido la condición: " + RequestCondition.INRECEPTION);
                }
            }
        }

        //Se debe colocar un evento para activar las booleanas correspondientes//
    }
    #endregion

    #region"FirstPart"
    private void FirstPart()
    {

        if(_currenStoryParts == StoryParts.FIRST_PART)
        {
            if(_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if(_currentRequestCondition == RequestCondition.OUTSIDETHEROOM)
                {

                }

            }else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {

                if (_currentRequestCondition == RequestCondition.LETTHESUICASE)
                {

                }

            }
            else if(_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {

                if (_currentRequestCondition == RequestCondition.SPOKELUNA)
                {

                }

            }
            else if(_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentRequestCondition == RequestCondition.INRECEPTION)
                {

                }
            }
            else if(_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {

                if (_currentRequestCondition == RequestCondition.SPOKELUNA)
                {

                }

            }
            else if(_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (_currentRequestCondition == RequestCondition.OUTSIDETHEHOTEL)
                {

                }

            }
        }

    }
    #endregion

    public void GameFlow()
    {
        switch (_switchIndex)
        {
            case 0:
                Introduction();
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }


  
}
