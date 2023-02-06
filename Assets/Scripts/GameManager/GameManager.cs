using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
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

    #region"References Inputs"
    UserActions _controls;
    #endregion

    #region"Reference UI"
    GameObject _elevatorUI;
    #endregion

    #region"Game Flow References"

    StoryParts _currenStoryParts;
    StagesStoryParts _currentStagesStoryParts;
    RequestCondition _currentRequestCondition;

    //Este int controla el Switch//

    int _switchIndex = 0;

    #endregion

    public Conversation _cesarsCurrentDialogue;

    public static bool _isTalking = false; 
    public static bool _isInventoryActive = false;
    public static bool _isMenuPauseActive = false;
    public static bool _isOpenInventory = false;
    //public static bool _playerCanMove = false;
    public static bool _isDialoguesLastLine = false;
    public static bool _nextLineActive = true;

    bool isElevatorUIActive = false;

    #region"Luna´s References"
    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] Transform _LunaSpawnPoint;
    GameObject _existLunaInTheScene;
    #endregion

    private void Awake()
    {
        _currenStoryParts = StoryParts.INTRODUCTION;
        _currentStagesStoryParts = StagesStoryParts.STAGE_1;
        _currentRequestCondition = RequestCondition.OUTSIDETHEHOTEL;

        _controls = new UserActions();
        _controls.Enable();

        _controls.Player.Enable();
        _controls.UI.Disable();
        _controls.UserMenu.Disable();
        _controls.Conversation.Disable();
        _controls.Elevator.Disable();

        EventManager.ConvesationStarts.AddListener(ConversationStarts);
        EventManager.ConvesationEnds.AddListener(ConversationEnds);
    }


    private void Start()
    {
        #region"Inputs"
        //Inputs//
        _controls = new UserActions();
        _controls.Enable();
        _controls.Player.Enable();
        _controls.UI.Disable();
        _controls.UserMenu.Disable();
        _controls.Conversation.Disable();

        EventManager._InputSet.Invoke(_controls);
        #endregion

        GameFlow();

        #region"UI"
        //Interfaz de ascensor//
        _elevatorUI = GameObject.Find(" ElevatorPanel");

        _elevatorUI.SetActive(false);

        #endregion

        #region"EventsAddlistener"
        //Preparar escucha de los eventos//

        EventManager._GoToMainMenu.AddListener(GoMenuPrincipalMain);
        EventManager._CheckConveElevator.AddListener(CheckIfYouCanUseTheElevator);
        EventManager._ChangeScene.AddListener(ChangeScene);
        #endregion

        #region"LunaSpawn"
        //Instanciado de luna en escena//
        EventManager._LunaPositionEvent.AddListener(NewPositionInTheScene);

        _existLunaInTheScene = GameObject.FindGameObjectWithTag("Luna");

        NewPositionInTheScene();

        #endregion

    }

    #region"NewPositionLuna"
    public void NewPositionInTheScene()
    {
        //Comprueba si luna existe en la escena//
        if (_existLunaInTheScene != null)
        {
            //Si existe la borra//
            Destroy(_existLunaInTheScene);
        }

        //Dependiendo de varias booleanas aparecera en una ubicación//
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
        else if (ProgressCheck._areWeInReception)
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

    #endregion

    #region"GoMenuPrincipal"
    public void GoMenuPrincipalMain()
    {
        //Nos devuelve al menu principal//
        SceneManager.LoadScene(0);
    }
    #endregion

    #region"ElevatorLogical"
    private void CheckIfYouCanUseTheElevator()
    {
        //Comprueba si Cesar puede usar el ascensor o debe decir un dialogo//

        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if (!JorgeDialogueManager._hasAlreadyTalkedToJorge)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_01");
                    print(_cesarsCurrentDialogue);
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    UIElevator();
                }

            }

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                if (_currentRequestCondition != RequestCondition.LETTHESUICASE)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    UIElevator();
                }
            }

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                if (_currentRequestCondition == RequestCondition.OUTSIDETHEROOM)
                {
                    if (!LunaDialogueManager._hasAlreadyTalkedToLuna)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_05");
                        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                    }
                    else
                    {
                        UIElevator();
                    }
                }

            }

        }
    }
    #endregion

    #region"UIElevator"
    private void UIElevator()
    {
        //Activa o Desactiva la interfaz del ascensor dependiendo de su estado//
        if (!_elevatorUI.activeSelf)
        {
            _elevatorUI.SetActive(true);
            isElevatorUIActive = true;
            EventManager._UseElevator.Invoke();
        }
        else
        {
            _elevatorUI.SetActive(false);
            isElevatorUIActive = false;
        }
    }
    #endregion

    #region"ChangeScene"
    private void ChangeScene(int _indexSceneUseButton)
    {
        //Cambia la escena dependiendo de un Index//
        SceneManager.LoadScene(_indexSceneUseButton);
    }
    #endregion


    #region"Introduction"
    private void Introduction()
    {
        if (_currenStoryParts == StoryParts.INTRODUCTION)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentRequestCondition == RequestCondition.INRECEPTION)
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

        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentRequestCondition == RequestCondition.OUTSIDETHEROOM)
                {

                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {

                if (_currentRequestCondition == RequestCondition.LETTHESUICASE)
                {

                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {

                if (_currentRequestCondition == RequestCondition.SPOKELUNA)
                {

                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentRequestCondition == RequestCondition.INRECEPTION)
                {

                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {

                if (_currentRequestCondition == RequestCondition.SPOKELUNA)
                {

                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (_currentRequestCondition == RequestCondition.OUTSIDETHEHOTEL)
                {

                }

            }
        }

    }
    #endregion

    #region "GameFlow"
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
    #endregion


    void ConversationStarts()
    {
        print("ConvesationStarts input map change");

        _controls.Player.Interactue.Disable();
        _controls.Player.Disable();
        _controls.Conversation.Enable();
    }

    void ConversationEnds()
    {
        print("ConversationEnds input map change");

        _controls.Conversation.Disable();
        _controls.Player.Enable();
    }


}
