using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    #region"Enums"
    public enum StoryParts
    {

        INTRODUCTION,
        FIRST_PART,
        SECOND_PART

    }

    public enum StagesStoryParts
    {

        STAGE_1,
        STAGE_2,
        STAGE_3,
        STAGE_4,
        STAGE_5,
        STAGE_6,
        STAGE_7,
        STAGE_8

    }

    public enum RequestCondition
    {
        OUTSIDETHEHOTEL,
        INRECEPTION,
        SPOKEJORGE,
        OUTSIDETHEROOM,
        LETTHESUICASE,
        SPOKELUNA,
        OUTSIDECENTURIONROOM,
        SPOKECENTURION,
        SPOKELUNAINRECEPTION,
        READYTOGO   

    }
    #endregion

    #region"References Inputs"
    UserActions _controls;
    #endregion

    #region"Reference UI"
    GameObject _elevatorUI;
    #endregion

    #region"Game Flow References"

    public StoryParts _currenStoryParts;
    public StagesStoryParts _currentStagesStoryParts;
    public RequestCondition _currentRequestCondition;

    //Este int controla el Switch//

    int _switchIndex = 0;

    #endregion

    public Conversation _cesarsCurrentDialogue;

    [SerializeField] string[] sceneWithDoor;

    bool isElevatorUIActive = false;

    bool _firtsTimeEntryInTheHotel = true;
    bool _tryExitTheReception = true;
    bool _firtsTimeEntryInTheRoom = true;
    bool _firtsTimeEntryInTheCenturionsRoom = true;
    bool _firtsTimeExitCenturionsRoom = true;
    bool _firtsTimeExitTheRoom = true;

    #region"Statics"
    public static bool _isTalking = false; 
    public static bool _isMenuPauseActive = false;
    public static bool _isOpenInventory = false;
    public static bool _isDialoguesLastLine = false;
    public static bool _nextLineActive = true;
    #endregion

    static int[] pastConversations = null;


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
        _controls.Inventory.Disable();
        _controls.OptionsMenu.Disable();
        _controls.Conversation.Disable();

        EventManager.ConvesationStarts.AddListener(ConversationStarts);
        EventManager.ConvesationEnds.AddListener(ConversationEnds);

        EventManager.UserMenuOff.AddListener(CloseOptionsMenu);
        EventManager.UserMenuOn.AddListener(OpenOptionsMenu);

        EventManager.UIOff.AddListener(CloseInventory);
        EventManager.UIOn.AddListener(OpenInventory);

        print("a");
        int[] v = { 0, 1, 3 };
        string s = PastConversationsToString(v);
        print(s);
    }


    private void Start()
    {
        #region"Inputs"
        //Inputs//
        _controls = new UserActions();
        _controls.Enable();
        _controls.Player.Enable();
        _controls.Inventory.Disable();
        _controls.OptionsMenu.Disable();
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
        EventManager._ChangeScene.AddListener(ElevatorChangeScene);
        EventManager.SendIndex.AddListener(CheckTheScene);
        EventManager.SpokeNPCRequest.AddListener(NextRequestCondition);

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
        UIElevator();

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
            EventManager.UIOn.Invoke();
        }
        else
        {
            _elevatorUI.SetActive(false);
            isElevatorUIActive = false;
            EventManager.UIOff.Invoke();
        }
    }
    #endregion

    #region"ChangeSceneElevator"
    private void ElevatorChangeScene(int _indexSceneUseButton)
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
                    _switchIndex++;
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
                if (_currentRequestCondition == RequestCondition.SPOKEJORGE)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_2;
                    _currentRequestCondition = RequestCondition.OUTSIDETHEROOM;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {

                if (_currentRequestCondition == RequestCondition.OUTSIDETHEROOM)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_3;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {

                if (_currentRequestCondition == RequestCondition.LETTHESUICASE)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_4;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentRequestCondition == RequestCondition.SPOKELUNA)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_5;
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {

                if (_currentRequestCondition == RequestCondition.OUTSIDECENTURIONROOM)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_6;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (_currentRequestCondition == RequestCondition.SPOKECENTURION)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_7;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {

                if (_currentRequestCondition == RequestCondition.SPOKELUNAINRECEPTION)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_8;
                }

            }else if(_currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {

                if(_currentRequestCondition == RequestCondition.READYTOGO)
                {
                    _currenStoryParts = StoryParts.SECOND_PART;
                    _currentStagesStoryParts = StagesStoryParts.STAGE_1;
                    _switchIndex++;
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

    #region"ConversationsInput"
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
    #endregion

    #region"UI"
    void OpenInventory()
    {
        _controls.Player.Disable();
        _controls.Inventory.Enable();
    }

    void CloseInventory()
    {
        _controls.Player.Enable();
        _controls.Inventory.Disable();
    }
    #endregion

    #region"UserMenu"
    void OpenOptionsMenu()
    {
        _controls.Player.Disable();
        _controls.OptionsMenu.Enable();
    }
    void CloseOptionsMenu()
    {
        _controls.Player.Enable();
        _controls.OptionsMenu.Disable();
    }
    #endregion

    public void NextRequestCondition()
    {
        if (_currenStoryParts == StoryParts.INTRODUCTION)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentRequestCondition == RequestCondition.OUTSIDETHEHOTEL)
                {
                    _currentRequestCondition = RequestCondition.INRECEPTION;
                    GameFlow();
                }
            }
        }

        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentRequestCondition == RequestCondition.INRECEPTION)
                {
                    _currentRequestCondition = RequestCondition.SPOKEJORGE;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if (_currentRequestCondition == RequestCondition.OUTSIDETHEROOM)
                {
                    _currentRequestCondition = RequestCondition.LETTHESUICASE;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                if (_currentRequestCondition == RequestCondition.LETTHESUICASE)
                {
                    _currentRequestCondition = RequestCondition.SPOKELUNA;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentRequestCondition == RequestCondition.SPOKELUNA)
                {
                    _currentRequestCondition = RequestCondition.OUTSIDECENTURIONROOM;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                if (_currentRequestCondition == RequestCondition.OUTSIDECENTURIONROOM)
                {
                    _currentRequestCondition = RequestCondition.SPOKECENTURION;
                    GameFlow();
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {
                if (_currentRequestCondition == RequestCondition.SPOKECENTURION)
                {
                    _currentRequestCondition = RequestCondition.SPOKELUNAINRECEPTION;
                    GameFlow();
                }
            } else if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {
                if (_currentRequestCondition == RequestCondition.SPOKELUNAINRECEPTION)
                {
                    _currentRequestCondition = RequestCondition.READYTOGO;
                    GameFlow();
                }
            }

        
        }
    }

    private void CheckTheScene(int indexSceneDoor)
    {
        Scene _currentScene = SceneManager.GetActiveScene();

        if (_currentScene.name == sceneWithDoor[0])
        {
            if (_firtsTimeEntryInTheHotel)
            {
                NextRequestCondition();
                _firtsTimeEntryInTheHotel = false;
                SceneManager.LoadScene(indexSceneDoor);
            }
            else
            {
                SceneManager.LoadScene(indexSceneDoor);
            }

        }
        else if (_currentScene.name == sceneWithDoor[1])
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {
                if (_tryExitTheReception)
                {
                    NextRequestCondition();
                    _tryExitTheReception = false;
                    //Evento para luna
                }
            }
            
            if(_currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {
                SceneManager.LoadScene(indexSceneDoor);

            }

        }
        else if (_currentScene.name == sceneWithDoor[2])
        {
            if (_firtsTimeEntryInTheRoom)
            {
                NextRequestCondition();
                _firtsTimeEntryInTheRoom = false;
                SceneManager.LoadScene(indexSceneDoor);
            }
            else
            {
                SceneManager.LoadScene(indexSceneDoor);

            }

        }
        else if (_currentScene.name == sceneWithDoor[3])
        {
            if (_firtsTimeExitTheRoom)
            {
                _firtsTimeExitTheRoom = false;
                SceneManager.LoadScene(indexSceneDoor);
                //Evento para luna aparezca

            }
            else
            {
                SceneManager.LoadScene(indexSceneDoor);
            }

        }
        else if (_currentScene.name == sceneWithDoor[4])
        {
            if (_firtsTimeEntryInTheCenturionsRoom)
            {
                NextRequestCondition();
                _firtsTimeEntryInTheCenturionsRoom = false;
                SceneManager.LoadScene(indexSceneDoor);
            }
            else
            {
                SceneManager.LoadScene(indexSceneDoor);

            }
        }
        else if (_currentScene.name == sceneWithDoor[5])
        {
            if (_firtsTimeExitCenturionsRoom)
            {
                _firtsTimeExitCenturionsRoom = false;
                SceneManager.LoadScene(indexSceneDoor);
            }
            else
            {
                SceneManager.LoadScene(indexSceneDoor);

            }
        }
    }

    public static int[] PastConversations
    {
        get
        {
            if (pastConversations == null)
            {
                // tomar los valores del archivo de guardado o donde sea
            }

            return pastConversations;
        }
    }

    void UpdateConversationLog(int index)
    {
        // añadir <index> a pastConversations
        int[] tmp;
        tmp = new int[pastConversations.Length];
        for (int i = 0; i < pastConversations.Length; i++)
            tmp[i] = pastConversations[i];

        pastConversations = new int[pastConversations.Length + 1];
        for (int i = 0; i < tmp.Length; i++)
            pastConversations[i] = tmp[i];
        pastConversations[pastConversations.Length - 1] = index;

        // sobreescribir pastConversations del archivo de guardado, con la nueva información

    }

    string PastConversationsToString(int[] prueba)
    {
        string s = "";

        for (int i = 0; i < prueba.Length; i++)
        {
            s += prueba[i];
            if (i != prueba.Length - 1)
                s += "-";
        }

        return s;
    }

    int[] PastConversationsToIntArray(string prueba)
    {
        int[] v;
        //string[] stringIndexes = PlayerPrefs.GetString("PastConversations").Split('-');
        string[] stringIndexes = prueba.Split('-');

        v = new int[stringIndexes.Length];
        for (int i = 0; i < stringIndexes.Length; i++)
            v[i] = int.Parse(stringIndexes[i]);

        return v;
    }
}
