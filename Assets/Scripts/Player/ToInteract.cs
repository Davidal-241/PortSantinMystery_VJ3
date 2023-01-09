using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToInteract : MonoBehaviour
{

    DialogueManager dialogueManager;
    [SerializeField] UserActions _controls;
    private InputAction Interact;
    private InputAction Inventory;
    private InputAction NextLine;

   

    private void Awake()
    {
        _controls = new UserActions();
    }

    private void Update()
    {
        if (GlobalBools._isTalking)
        {
            if (GlobalBools._nextLineActive)
            {

                dialogueManager = FindObjectOfType<DialogueManager>();


            }
        }
    }

    public void OnEnable()
    {

        Interact = _controls.Player.Interactue;
        Interact.Enable();
        Interact.performed += StartInteract;
       
        Inventory = _controls.Player.Inventory;
        Inventory.Enable();
        Inventory.performed += OpenInventory;

        NextLine = _controls.UI.NextLine;

        NextLine.Enable();

        NextLine.performed += NextLineText;
    }

    public void OnDisable()
    {
        Interact.Disable();
        Inventory.Disable();
        NextLine.Disable();
    }


    private void OpenInventory(InputAction.CallbackContext context)
    {
        
        if (!GlobalBools._canOpenInventory)
        {

            
            GlobalBools._canOpenInventory = true;
            GlobalBools._canSubmit = true;
            EventManager._OpenInventory.Invoke();

        }
        else
        {

            GlobalBools._canOpenInventory = false;
            GlobalBools._isInventoryActive = false;
            GlobalBools._canSubmit = false;
            EventManager._CloseInventory.Invoke();


        }
    }

    private void StartInteract(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isTalking)
        {

            if (GlobalBools._canTalk)
            {
                EventManager._Talk.Invoke();
                GlobalBools._isWaitingForInteractue = true;

            }


            if (GlobalBools._canOpenDoor)
            {
                if (!ProgressCheck._areWeOutsideTheWeRoom)
                {
                    if (ProgressCheck._canYouExit)
                    {
                        EventManager._changeScene.Invoke();
                    }
                    else
                    {
                        ProgressCheck._youTryGoOutside = true;
                    }

                }

                if (ProgressCheck._areWeOutsideTheCenturionRoom)
                {
                    EventManager._changeScene.Invoke();
                }

                if (ProgressCheck._areWeOutsideTheWeRoom)
                {
                    ProgressCheck._canYouInteractWithYourDoor = true;
                }
            }

            if (GlobalBools._isCloseToElevator)
            {
                EventManager._EnterInElevator.Invoke();
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
            print("GlobalBools._isDialoguesLastLine: " + GlobalBools._isDialoguesLastLine);

                dialogueManager.ReadNext();
          
        }
    }
}
