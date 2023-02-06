using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToInteract : MonoBehaviour
{

    [SerializeField]LogicalDialogueSystem logicalDialogueManager;
    [SerializeField] UserActions _controls;

    private void Awake()
    {

        EventManager._InputSet.AddListener(InputSet);

        logicalDialogueManager = FindObjectOfType<LogicalDialogueSystem>();
        print(logicalDialogueManager);
    }




    void InputSet(UserActions input)
    {
        _controls = input;
        //_controls.Player.Interactue.performed += StartInteract;
        _controls.Conversation.NextLine.performed += NextLineText;
    }

    //private void StartInteract(InputAction.CallbackContext context)
    //{
    //    print("start interaction");

    //    if (!GlobalBools._isTalking || !GlobalBools._isMenuPauseActive)
    //    {
    //        EventManager._InteractionStart.Invoke();

    //    }

    //}

    public void NextLineText(InputAction.CallbackContext context)
    {
        //if (GameManager._isTalking && !GameManager._isMenuPauseActive)
        {
            logicalDialogueManager.ReadNext();
        }
    }
}
