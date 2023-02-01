using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    UserActions _controls;
    GameObject _elevatorUI;

    public Conversation _cesarsCurrentDialogue;

    [SerializeField] GameObject _lunaPrefab;
    [SerializeField] Transform _LunaSpawnPoint;
    GameObject _existLunaInTheScene;

    private void Start()
    {
        //Inputs//
        _controls = new UserActions();
        _controls.Enable();
        _controls.Player.Enable();
        _controls.UI.Disable();
        _controls.UserMenu.Disable();
        _controls.Conversation.Disable();

        EventManager._InputSet.Invoke(_controls);

        //Interfaz de ascensor//
        _elevatorUI = GameObject.Find(" ElevatorPanel");

        _elevatorUI.SetActive(false);

        //Preparar escucha de los eventos//

        EventManager._GoToMainMenu.AddListener(GoMenuPrincipalMain);
        EventManager._CheckConveElevator.AddListener(CheckIfYouCanUseTheElevator);
        EventManager._ChangeScene.AddListener(ChangeScene);

        //Instanciado de luna en escena//
        EventManager._LunaPositionEvent.AddListener(NewPositionInTheScene);

        _existLunaInTheScene = GameObject.FindGameObjectWithTag("Luna");

        NewPositionInTheScene();


    }

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

    public void GoMenuPrincipalMain()
    {
        //Nos devuelve al menu principal//
        SceneManager.LoadScene(0);
    }

    private void CheckIfYouCanUseTheElevator()
    {
        //Comprueba si Cesar puede usar el ascensor o debe decir un dialogo//

        if (ProgressCheck._areWeInTheSecondPart)
        {
            if (ProgressCheck._areWeInTheStage2)
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

            if (ProgressCheck._areWeInTheStage3)
            {
                if (!ProgressCheck._didYouLeaveTheSuitcase)
                {
                    _cesarsCurrentDialogue = Resources.Load<Conversation>("Cesar/GF_Dialogues/Cesar_GF_Dialogue_03");
                    EventManager._ConversationStarts.Invoke(_cesarsCurrentDialogue);
                }
                else
                {
                    UIElevator();
                }
            }

            if (ProgressCheck._areWeInTheStage5)
            {
                if (GlobalBools._isInFirstFloor)
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

    private void UIElevator()
    {
        //Activa o Desactiva la interfaz del ascensor dependiendo de su estado//
        if (!_elevatorUI.activeSelf)
        {
            _elevatorUI.SetActive(true);
            GlobalBools._isElevatorUIActive = true;
            EventManager._UseElevator.Invoke();
        }
        else
        {
            _elevatorUI.SetActive(false);
            GlobalBools._isElevatorUIActive = false;
        }
    }

    private void ChangeScene(int _indexSceneUseButton)
    {
        //Cambia la escena dependiendo de un Index//
        SceneManager.LoadScene(_indexSceneUseButton);
    }

}
