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
        INTERACTUEWITHCENTURIONDOOR,
        SPEAKWITHLUNAINRECEPTION,
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
    public RequestCondition _currentQuest;

    //Este int controla el Switch//

    int _switchIndex = 0;

    #endregion

    protected GameObject _player;

    public Conversation _cesarsCurrentDialogue;

    Scene _currentScene;

    protected static string _previousSceneName = null;

    [SerializeField] string[] sceneWithDoor;

    #region"Bools"
    bool isElevatorUIActive = false;

    bool _firtsTimeEntryInTheHotel = true;
    bool _tryExitTheReception = true;
    bool _firtsTimeEntryInTheRoom = true;
    bool _firtsTimeEntryInTheCenturionsRoom = true;
    bool _firtsTimeExitTheRoom = true;
    bool _hasAlreadyInteractueWithCenturionDoor = false;
    #endregion

    #region"Statics"
    public static bool _isTalking = false; 
    public static bool _isMenuPauseActive = false;
    public static bool _isOpenInventory = false;
    public static bool _isDialoguesLastLine = false;
    public static bool _nextLineActive = true;
    #endregion

    static int[] pastConversations = null;

    [SerializeField] bool shouldDeletePlayePrefs = false;


    private void Awake()
    {
        if (shouldDeletePlayePrefs)
            PlayerPrefs.SetString("PastConversations", "");

        //UpdateConversationLog(0);
        //UpdateConversationLog(2);

        _currenStoryParts = StoryParts.INTRODUCTION;
        _currentStagesStoryParts = StagesStoryParts.STAGE_1;
        _currentQuest = RequestCondition.OUTSIDETHEHOTEL;

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

        //int[] v = { 0, 1, 3, 0, 5 };
        //pastConversations = v;



        //string s = PastConversationsToString(v);


        //int[] w = GameManager.GetConversations();
        //for (int i = 0; i < w.Length; i++)
        //{
        //    print(w[i]);
        //    pestaña.Add(RegisteredConversations[w[i]])
        //}

        _player = GameObject.FindGameObjectWithTag("Player");
    }

    protected virtual void Start()
    {
        
        _previousSceneName = SceneManager.GetActiveScene().name;

        _currentScene = SceneManager.GetActiveScene();

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
        EventManager.NextRequest.AddListener(NextRequestCondition);
        EventManager.InteractueWithCenturionDoors.AddListener(CenturionDoorDialogues);

        #endregion

    }

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
                if (_currentQuest != RequestCondition.LETTHESUICASE)
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
                if (_currentQuest == RequestCondition.OUTSIDETHEROOM)
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

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {
                if (_currentQuest == RequestCondition.OUTSIDECENTURIONROOM)
                {
                    if (!_hasAlreadyInteractueWithCenturionDoor)
                    {
                        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_07");
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
        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if(_indexSceneUseButton == 2)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                }
                else
                {
                    SceneManager.LoadScene(_indexSceneUseButton);
                }
            }
        }
    }
    #endregion

    #region"Introduction"
    private void Introduction()
    {
        if (_currenStoryParts == StoryParts.INTRODUCTION)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentQuest == RequestCondition.INRECEPTION)
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
                if (_currentQuest == RequestCondition.SPOKEJORGE)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_2;
                    _currentQuest = RequestCondition.OUTSIDETHEROOM;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {

                if (_currentQuest == RequestCondition.OUTSIDETHEROOM)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_3;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {

                if (_currentQuest == RequestCondition.LETTHESUICASE)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_4;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentQuest == RequestCondition.SPOKELUNA)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_5;
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {

                if (_currentQuest == RequestCondition.OUTSIDECENTURIONROOM)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_6;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (_currentQuest == RequestCondition.INTERACTUEWITHCENTURIONDOOR)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_7;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {

                if (_currentQuest == RequestCondition.SPEAKWITHLUNAINRECEPTION)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_8;
                }

            }else if(_currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {

                if(_currentQuest == RequestCondition.READYTOGO)
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

    #region"NextRequest"
    public void NextRequestCondition()
    {
        if (_currenStoryParts == StoryParts.INTRODUCTION)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentQuest == RequestCondition.OUTSIDETHEHOTEL)
                {
                    _currentQuest = RequestCondition.INRECEPTION;
                    GameFlow();
                }
            }
        }

        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentQuest == RequestCondition.INRECEPTION)
                {
                    _currentQuest = RequestCondition.SPOKEJORGE;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if (_currentQuest == RequestCondition.OUTSIDETHEROOM)
                {
                    _currentQuest = RequestCondition.LETTHESUICASE;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                if (_currentQuest == RequestCondition.LETTHESUICASE)
                {
                    _currentQuest = RequestCondition.SPOKELUNA;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentQuest == RequestCondition.SPOKELUNA)
                {
                    _currentQuest = RequestCondition.OUTSIDECENTURIONROOM;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                if (_currentQuest == RequestCondition.OUTSIDECENTURIONROOM)
                {
                    _currentQuest = RequestCondition.INTERACTUEWITHCENTURIONDOOR;
                    GameFlow();
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {
                if (_currentQuest == RequestCondition.INTERACTUEWITHCENTURIONDOOR)
                {
                    _currentQuest = RequestCondition.SPEAKWITHLUNAINRECEPTION;
                    GameFlow();
                }
            } else if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {
                if (_currentQuest == RequestCondition.SPEAKWITHLUNAINRECEPTION)
                {
                    _currentQuest = RequestCondition.READYTOGO;
                    GameFlow();
                }
            }
        }
    }

    #endregion

    #region"CenturionDoorDialogues"

    private void CenturionDoorDialogues()
    {
        _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_08");
        EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
        NextRequestCondition();
    }

    #endregion

    #region"Check the scene if use door"
    private void CheckTheScene(int indexSceneDoor)
    {
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
    }

    #endregion

    public static int[] PastConversations
    {
        get
        {
            if (pastConversations == null)
            {
                pastConversations = PastConversationsToIntArray(PlayerPrefs.GetString("PastConversations"));
            }

            return pastConversations;
        }
    }

    public static void UpdateConversationLog(int index)
    {
        // añadir <index> a pastConversations
        int[] tmp;
        tmp = new int[PastConversations.Length];
        for (int i = 0; i < PastConversations.Length; i++)
            tmp[i] = PastConversations[i];

        pastConversations = new int[PastConversations.Length + 1];
        for (int i = 0; i < tmp.Length; i++)
            pastConversations[i] = tmp[i];
        pastConversations[pastConversations.Length - 1] = index;

        string encoded = PastConversationsToString(pastConversations);

        // sobreescribir pastConversations del archivo de guardado, con la nueva información
        PlayerPrefs.SetString("PastConversations", encoded);
    }

    static string PastConversationsToString(int[] decoded)
    {
        string s = "";

        for (int i = 0; i < decoded.Length; i++)
        {
            s += decoded[i];
            if (i != decoded.Length - 1)
                s += "-";
        }

        return s;
    }

    static int[] PastConversationsToIntArray(string encoded)
    {
        int[] v;
        //string[] stringIndexes = PlayerPrefs.GetString("PastConversations").Split('-');
        string[] stringIndexes = encoded.Split('-');

        // In case there still is no registered conversation
        if (stringIndexes.Length == 1 && stringIndexes[0].Length == 0)
        {
            return new int[0];
        }

        v = new int[stringIndexes.Length];
        for (int i = 0; i < stringIndexes.Length; i++)
            v[i] = int.Parse(stringIndexes[i]);

        return v;
    }

    public static int[] GetConversations()
    {
        return PastConversationsToIntArray(PlayerPrefs.GetString("PastConversations"));
    }
}
