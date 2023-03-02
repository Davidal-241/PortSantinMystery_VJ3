using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

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
    STAGE_8,
    STAGE_9
}

public enum FinishedQuest
{
    OUTSIDETHEHOTEL,
    INRECEPTION,
    SPOKEJORGE,
    OUTSIDETHEROOM,
    LEAVESUITCASE,
    SPOKELUNA,
    OUTSIDECENTURIONROOM,
    INTERACTUEWITHCENTURIONDOOR,
    SPEAKWITHLUNAINRECEPTION,
    READYTOGO

}
#endregion

public class GameManager : MonoBehaviour
{


    #region"References Inputs"
    UserActions _controls;
    #endregion

    #region"Game Flow References"

    public static StoryParts _currenStoryParts;
    public static StagesStoryParts _currentStagesStoryParts;
    public static FinishedQuest _currentQuest;

    //Este int controla el Switch//

    static int _switchIndex = 0;

    #endregion

    protected GameObject _player;

    public Conversation _cesarsCurrentDialogue;

    Scene _currentScene;

    protected static string _previousSceneName = null;

    [SerializeField] string[] sceneWithDoor;

    #region"Bools"
    protected bool isElevatorUIActive = false;

    bool _firtsTimeEntryInTheHotel = true;
    bool _tryExitTheReception = true;
    bool _firtsTimeEntryInTheRoom = true;
    bool _firtsTimeEntryInTheCenturionsRoom = true;
    bool _firtsTimeExitTheRoom = true;
    bool _firtsTimeInTheOutsideCesarRoom = true;
    bool _firtsTimeInTheOutsideCenturionRoom = true;
    protected bool _hasAlreadyInteractueWithCenturionDoor = false;

    public static bool _isntHandFree = true;

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

    GameObject _cesarMaleta;
    GameObject _cesarSinMaleta;

    [SerializeField] Animator _fadeInAni;

    private void Awake()
    {
        if (shouldDeletePlayePrefs)
            PlayerPrefs.SetString("PastConversations", "");

        //UpdateConversationLog(0);
        //UpdateConversationLog(2);

       

        _controls = new UserActions();
        _controls.Enable();

        _controls.Player.Enable();
        _controls.Inventory.Disable();
        _controls.OptionsMenu.Disable();
        _controls.Conversation.Disable();


        _fadeInAni = GameObject.Find("FadeIn").GetComponent<Animator>();

        EventManager.ConvesationStarts.AddListener(ConversationStarts);
        EventManager.ConvesationEnds.AddListener(ConversationEnds);

        EventManager.NextRequest.AddListener(NextRequestCondition);

        EventManager.UserMenuOff.AddListener(CloseOptionsMenu);
        EventManager.UserMenuOn.AddListener(OpenOptionsMenu);

        EventManager.UIOff.AddListener(CloseInventory);
        EventManager.UIOn.AddListener(OpenInventory);

        EventManager._ChangeScene.AddListener(ElevatorChangeScene);

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
        _cesarMaleta = GameObject.Find("Cesar");
        _cesarSinMaleta = GameObject.Find("Cesar_NoMaleta");

       

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


        #region"EventsAddlistener"
        //Preparar escucha de los eventos//

        EventManager._GoToMainMenu.AddListener(GoMenuPrincipalMain);
        EventManager.SendIndex.AddListener(CheckTheScene);
        EventManager.NextRequest.AddListener(NextRequestCondition);
        EventManager.InteractueWithCenturionDoors.AddListener(CenturionDoorDialogues);

        #endregion

        if (!_isntHandFree)
        {
            
            _cesarMaleta.SetActive(false);
            _cesarSinMaleta.SetActive(true);
        }
        else
        {
            _cesarMaleta.SetActive(true);
            _cesarSinMaleta.SetActive(false);
        }
    }

    #region"GoMenuPrincipal"
    public void GoMenuPrincipalMain()
    {
        //Nos devuelve al menu principal//
        SceneManager.LoadScene("MainMenu");
    }
    #endregion


    #region"ChangeSceneElevator"
    private void ElevatorChangeScene(string _sceneName)
    {
        //Cambia la escena dependiendo de un String//
        if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if(string.Compare(_sceneName, "Pasillo Centurion") == 0)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);

                }
                else if(_currentQuest == FinishedQuest.SPOKEJORGE)
                {
                    if (_firtsTimeInTheOutsideCesarRoom)
                    {
                        _firtsTimeInTheOutsideCesarRoom = false;
                        NextRequestCondition();
                        StartCoroutine(ElevatorFadeInCorutine(_sceneName));
                    }
                }
            }
            else if(_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (string.Compare(_sceneName, "Pasillo Centurion") == 0)
                {
                    if (_firtsTimeInTheOutsideCenturionRoom)
                    {
                        _firtsTimeInTheOutsideCenturionRoom = false;
                        NextRequestCondition();
                        StartCoroutine(ElevatorFadeInCorutine(_sceneName));
                    }

                }
                else if (string.Compare(_sceneName, "Vestibulo") == 0)
                {
                    StartCoroutine(ElevatorFadeInCorutine(_sceneName));

                }
                else if(string.Compare(_sceneName, "Pasillo") == 0)
                {
                    StartCoroutine(ElevatorFadeInCorutine(_sceneName));
                }
            }
            else
            {
                StartCoroutine(ElevatorFadeInCorutine(_sceneName));
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
                if (_currentQuest == FinishedQuest.INRECEPTION)
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
                if (_currentQuest == FinishedQuest.SPOKEJORGE)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_2;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if (_currentQuest == FinishedQuest.OUTSIDETHEROOM)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_3;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {

                if (_currentQuest == FinishedQuest.LEAVESUITCASE)
                {
                    
                    _currentStagesStoryParts = StagesStoryParts.STAGE_4;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentQuest == FinishedQuest.SPOKELUNA)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_5;
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {
                
                    if (_currentQuest == FinishedQuest.OUTSIDECENTURIONROOM)
                    {
                        print("poniendo la 6");
                        _currentStagesStoryParts = StagesStoryParts.STAGE_6;
                    }
                

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (_currentQuest == FinishedQuest.INTERACTUEWITHCENTURIONDOOR)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_7;
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {
                
                if (_currentQuest == FinishedQuest.SPEAKWITHLUNAINRECEPTION)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_8;
                }

            }
            else if(_currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {

                if(_currentQuest == FinishedQuest.READYTOGO)
                {
                    _currentStagesStoryParts = StagesStoryParts.STAGE_9;
                    
                }

            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_9)
            {


                SceneManager.LoadScene("Creditos");
                Destroy(MusicScript.instance);
                GameObject _musicsongObject = GameObject.Find("MusicSound");
                Destroy(_musicsongObject);

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
                
                FirstPart();
                break;
            case 2:
                
                break;
        }
    }
    #endregion

    #region"ConversationsInput"
    void ConversationStarts()
    {

        _controls.Player.Interactue.Disable();
        _controls.Player.Disable();
        _controls.Conversation.Enable();
    }

    void ConversationEnds()
    {

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
        print("NextRequestCondition: " + _currenStoryParts + " - " + _currentStagesStoryParts + " - " + _currentQuest + " - " + _currentScene);

        if (_currenStoryParts == StoryParts.INTRODUCTION)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentQuest == FinishedQuest.OUTSIDETHEHOTEL)
                {
                    _currentQuest = FinishedQuest.INRECEPTION;
                    GameFlow();
                }
            }
        }

        else if (_currenStoryParts == StoryParts.FIRST_PART)
        {
            if (_currentStagesStoryParts == StagesStoryParts.STAGE_1)
            {
                if (_currentQuest == FinishedQuest.INRECEPTION)
                {
                    //Hablo con Jorge
                    _currentQuest = FinishedQuest.SPOKEJORGE;
                    GameFlow();
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_2)
            {
                if (_currentQuest == FinishedQuest.SPOKEJORGE)
                {
                    if (!_firtsTimeInTheOutsideCesarRoom)
                    {
                        _currentQuest = FinishedQuest.OUTSIDETHEROOM;
                        GameFlow();
                    }
                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_3)
            {
                if (_currentQuest == FinishedQuest.OUTSIDETHEROOM)
                {
                    if (!_firtsTimeEntryInTheRoom)
                    {

                        _currentQuest = FinishedQuest.LEAVESUITCASE;
                    
                        GameFlow();
                    }

                }
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_4)
            {
                if (_currentQuest == FinishedQuest.LEAVESUITCASE)
                {
                     _currentQuest = FinishedQuest.SPOKELUNA;

                    
                    Debug.Log("Good result");

                    GameFlow();
                   
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_5)
            {

                if (LunaDialogueManager._hasAlreadyTalkedToLuna)
                {

                    if (_currentQuest == FinishedQuest.SPOKELUNA)
                    {
                        _currentQuest = FinishedQuest.OUTSIDECENTURIONROOM;
                        GameFlow();

                    }
                }
               
            }

            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_6)
            {

                if (!_firtsTimeInTheOutsideCenturionRoom)
                {
                    if (_currentQuest == FinishedQuest.OUTSIDECENTURIONROOM)
                    {
                        _currentQuest = FinishedQuest.INTERACTUEWITHCENTURIONDOOR;
                        GameFlow();


                    }
                }
            } 
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {
                if (_currentQuest == FinishedQuest.INTERACTUEWITHCENTURIONDOOR)
                {
                    _currentQuest = FinishedQuest.SPEAKWITHLUNAINRECEPTION;
                    GameFlow();
                }
            }
            else if (_currentStagesStoryParts == StagesStoryParts.STAGE_8)
            {
                if (_currentQuest == FinishedQuest.SPEAKWITHLUNAINRECEPTION)
                {

                    _currentQuest = FinishedQuest.READYTOGO;
                    GameFlow();
                }
            }
        }
    }

    #endregion

    #region"CenturionDoorDialogues"

    private void CenturionDoorDialogues()
    {
        if (_currenStoryParts == StoryParts.FIRST_PART)
        {

            if (_currentStagesStoryParts == StagesStoryParts.STAGE_7)
            {
                print("EEEE");
                _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_08");
                EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                NextRequestCondition();
            }
        }
    }

    #endregion

    #region"Check the scene if use door"
    private void CheckTheScene(string indexSceneDoor)
    {
        //print("CheckTheScene: " + _currenStoryParts + " - " + _currentStagesStoryParts + " - " + _currentQuest + " - " + _firtsTimeEntryInTheRoom + " - " + _currentScene.name);

        if (_currentScene.name == sceneWithDoor[0])
        {
            if (_firtsTimeEntryInTheHotel)
            {

                NextRequestCondition();

                _firtsTimeEntryInTheHotel = false;

                StartCoroutine(DoorFadeInCorutine(indexSceneDoor));

            }
            else
            {
                StartCoroutine(DoorFadeInCorutine(indexSceneDoor));
            }

        }
        else if (_currentScene.name == sceneWithDoor[1])
        {
            if (_currenStoryParts == StoryParts.FIRST_PART)
            {

                if (_currentStagesStoryParts == StagesStoryParts.STAGE_8)
                {
                    if (_tryExitTheReception)
                    {

                        EventManager.LunaInReceptionTalk.Invoke();

                        _tryExitTheReception = false;
                    }
                }
                else if (_currentStagesStoryParts == StagesStoryParts.STAGE_9)
                {
                    GameFlow();

                }
                else if (_currentStagesStoryParts == StagesStoryParts.STAGE_1 || _currentStagesStoryParts == StagesStoryParts.STAGE_2)
                {
                    print("Cant Open");
                }
            }

        }
        else if (_currentScene.name == sceneWithDoor[2])
        {
            if (_currenStoryParts == StoryParts.FIRST_PART)
            {

                if (_firtsTimeEntryInTheRoom)
                {
                    _firtsTimeEntryInTheRoom = false;
                    NextRequestCondition();

                    StartCoroutine(DoorFadeInCorutine(indexSceneDoor));
                }
                else
                {
                    StartCoroutine(DoorFadeInCorutine(indexSceneDoor));
                }
            }
        }
        else if (_currentScene.name == sceneWithDoor[3])
        {

            if (_currenStoryParts == StoryParts.FIRST_PART)
            {
                if (_firtsTimeExitTheRoom)
                {
                    _firtsTimeExitTheRoom = false;
                    //NextRequestCondition();

                    StartCoroutine(DoorFadeInCorutine(indexSceneDoor));

                    _isntHandFree = false;

                    _cesarMaleta.SetActive(false);
                    _cesarSinMaleta.SetActive(true);
                }
                else
                {
                    StartCoroutine(DoorFadeInCorutine(indexSceneDoor));
                }
                //Evento para luna aparezca
            }
        }
    }

    #endregion

    IEnumerator ElevatorFadeInCorutine(string indexSceneElevator)
    {
        _fadeInAni.SetTrigger("StartFadeIn");
        yield return new WaitForSeconds(0.5f);

        EventManager.ElevatorSound.Invoke();
        SceneManager.LoadScene(indexSceneElevator);

        yield return null;
    }
    IEnumerator DoorFadeInCorutine(string indexSceneDoor)
    {
        _fadeInAni.SetTrigger("StartFadeIn");
        yield return new WaitForSeconds(0.5f);

        EventManager.DoorSound.Invoke();
        SceneManager.LoadScene(indexSceneDoor);

        yield return null;
    }

    #region "Log"
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
        EventManager.WritingSound.Invoke();
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
    #endregion
}
