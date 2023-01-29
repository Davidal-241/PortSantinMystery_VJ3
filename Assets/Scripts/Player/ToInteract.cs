using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToInteract : MonoBehaviour
{

    LogicalDialogueSystem logicalDialogueManager;
    [SerializeField] UserActions _controls;
    private InputAction Interact;

    private InputAction NextLine;

   

    private void Awake()
    {
        _controls = new UserActions();

        logicalDialogueManager = FindObjectOfType<LogicalDialogueSystem>();
    }


    public void OnEnable()
    {

        Interact = _controls.Player.Interactue;
        Interact.Enable();
        Interact.performed += StartInteract;
       
      

        NextLine = _controls.UI.NextLine;

        NextLine.Enable();

        NextLine.performed += NextLineText;
    }

    public void OnDisable()
    {
        Interact.Disable();
        NextLine.Disable();
    }



    private void StartInteract(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isTalking)
        {
            EventManager._InteractionStart.Invoke();

            if (GlobalBools._isCloseToElevator)
            {
                GlobalBools._canSubmit = true;

            }

            if (GlobalBools._isCloseToBed)
            {
                if (ProgressCheck._canYouInteractWithYourBed)
                {
                    ProgressCheck._didYouLeaveTheSuitcase = true;
                }
            }

            if (GlobalBools._isCloseToGlasses)
            {
                ProgressCheck._didYouInteractWithTheGlasses = true;
            }
        }

    }

    public void NextLineText(InputAction.CallbackContext context)
    {
        if (GlobalBools._isTalking)
        {
            logicalDialogueManager.ReadNext();
        }
    }
}
