using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using System;
using System.Diagnostics;

public class LogicalDialogueSystem : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue;
    public Image speakerSprite1;
    public Image speakerSprite2;

    [SerializeField] private int currentIndex;
    private Conversation currentConvo;
    private static LogicalDialogueSystem instance;
    private Coroutine typingCoroutine;

    bool _typingHasStarted = false;
    bool _lineFinishedTyping = false;

    bool instaCompleting = false;
    [SerializeField] float _betweenLettersWaitTime;
    float _instaCompleteTime = 0;

    [SerializeField] GameObject _dialogueBox;

    int dialogueIndex;

    [SerializeField] private SoundManager _soundManager; 

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //_soundManager = FindObjectOfType<SoundManager>();
        //_dialogueBox = GameObject.Find("DialogueBox");

    }

    public static void StartConversation(Conversation convo)
    {
        print("StartConversation");

        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        //GameManager._playerCanMove = true;

        EventManager.ConvesationStarts.Invoke();

        //print("Call from " + new StackTrace().GetFrame(0).GetMethod().Name + ". start convo. " + instance.currentIndex);
        instance.ReadNext();


    }


    public void ReadNext()
    {
        print(currentConvo);
        print(currentIndex + " / " + currentConvo.GetLength());

        // End conversation
        if (currentIndex >= currentConvo.GetLength() && typingCoroutine == null)
        {
            print("end conversation on line " + currentIndex);

            EndDialogue();

            return;
        }

        // Start conversation line
        else if (!_typingHasStarted)
        {
            print("start conversation line " + currentIndex);

            if (typingCoroutine != null)
                instance.StopCoroutine(typingCoroutine);

            StartNewLine();
            _typingHasStarted = true;
        }

        // End conversation line
        else if (typingCoroutine == null)
        {
            print("end conversation line " + currentIndex);

            StartNewLine();


            //if (typing == null)
            //{
            //    typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
            //}
            //else
            //{
            //    instance.StopCoroutine(typing);
            //    typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
            //}
        }

        // Insta complete conversation line
        else
        {
            instaCompleting = true;
            //print("insta complete line " + (currentIndex-1));
            //instance.StopCoroutine(typingCoroutine);
            //typingCoroutine = null;
            //dialogue.text += currentConvo.GetLineByIndex(currentIndex-1).dialogue.Substring(dialogueIndex);

            //// Remove all / characters

            //int slashIndex = dialogue.text.IndexOf('/');
            //while (slashIndex != -1)
            //{
            //    dialogue.text = dialogue.text.Remove(slashIndex, 1);
            //    slashIndex = dialogue.text.IndexOf('/');
            //}


            //dialogue.text = dialogue.text.Trim(new char[] { '/' });

            //_lineFinishedTyping = true;
            //currentIndex++;
        }


        // Display the current conversartion line images
        if (currentIndex < currentConvo.GetLength())
        {
            speakerSprite1.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains1;
            speakerSprite2.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains2;
        }


    }

    void StartNewLine()
    {
        typingCoroutine = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();

        speakerSprite1.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains1;
        speakerSprite2.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains2;
        
        currentIndex++;
    }

 
    public void EndDialogue()
    {
        //GameManager._playerCanMove = false;
        _dialogueBox.SetActive(false);
        print("EndDialogue/ Is DialogueBox in False?: " + _dialogueBox.activeSelf);

        currentIndex = 0;
        _typingHasStarted = false;

        speakerSprite1.sprite = null;
        speakerSprite2.sprite = null;
        GameManager._isTalking = false;

        EventManager.ConvesationEnds.Invoke();

    }

    private IEnumerator TypeText(string text)
    {
        print("printing line " + currentIndex);

        dialogue.text = "";
        bool complete = false;
        dialogueIndex = 0;
        //_lineFinishedTyping = false;

        while (!complete)
        {
            if (text[dialogueIndex] != '/')
            {
                dialogue.text += text[dialogueIndex];
                //_soundManager.TypeSound();
            }
            dialogueIndex++;
            
            yield return new WaitForSeconds(instaCompleting ? _instaCompleteTime : _betweenLettersWaitTime);

            if(dialogueIndex == text.Length)
            {
                complete = true;
            }
        }

        instaCompleting = false;

        //_lineFinishedTyping = true;
        typingCoroutine = null;
    }
}
