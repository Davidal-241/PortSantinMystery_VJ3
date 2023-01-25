using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using System;
using System.Diagnostics;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite1;
    public Image speakerSprite2;

    [SerializeField]private int currentIndex;
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Coroutine typingCoroutine;

    bool _typingHasStarted = false;
    bool _lineFinishedTyping = false;

    [SerializeField] float _betweenLettersWaitTime;

    [SerializeField] GameObject _dialogueBox;

    int dialogueIndex;

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

        _dialogueBox = GameObject.Find("DialogueBox");
     
    }

    public static void StartConversation(Conversation convo)
    {
        print("StartConversation");

        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";
        GlobalBools._playerCanMove = true;

        //print("Call from " + new StackTrace().GetFrame(0).GetMethod().Name + ". start convo. " + instance.currentIndex);
        //instance.ReadNext();


    }


    public void ReadNext()
    {
        print(currentIndex + " / " + currentConvo.GetLength());

        // End conversation
        if (currentIndex == currentConvo.GetLength() && typingCoroutine == null)
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
            print("insta complete line " + (currentIndex-1));
            instance.StopCoroutine(typingCoroutine);
            typingCoroutine = null;
            dialogue.text += currentConvo.GetLineByIndex(currentIndex-1).dialogue.Substring(dialogueIndex);

            // Remove all / characters

            int slashIndex = dialogue.text.IndexOf('/');
            while (slashIndex != -1)
            {
                dialogue.text = dialogue.text.Remove(slashIndex, 1);
                slashIndex = dialogue.text.IndexOf('/');
            }


            //dialogue.text = dialogue.text.Trim(new char[] { '/' });

            //_lineFinishedTyping = true;
            //currentIndex++;
        }


        // Display the current conversartion line images
        speakerSprite1.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains1;
        speakerSprite2.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains2;

        
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
        GlobalBools._playerCanMove = false;
        _dialogueBox.SetActive(false);
        currentIndex = 0;
        _typingHasStarted = false;
        speakerSprite1.sprite = null;
        speakerSprite2.sprite = null;
        GlobalBools._isTalking = false;
    }

    private IEnumerator TypeText(string text)
    {

        dialogue.text = "";
        bool complete = false;
        dialogueIndex = 0;
        //_lineFinishedTyping = false;

        while (!complete)
        {
            if (text[dialogueIndex] != '/')
                dialogue.text += text[dialogueIndex];
            dialogueIndex++;
            
            yield return new WaitForSeconds(_betweenLettersWaitTime);

            if(dialogueIndex == text.Length)
            {
                complete = true;
            }
        }

        //_lineFinishedTyping = true;
        typingCoroutine = null;
    }
}
