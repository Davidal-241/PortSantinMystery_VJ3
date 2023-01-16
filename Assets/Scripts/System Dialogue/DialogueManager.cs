using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using System;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite1;
    public Image speakerSprite2;

    [SerializeField]private int currentIndex;
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Coroutine typing;

    bool _isEndTyping = true;

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
       
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";
        GlobalBools._isBlockTheMovement = true;
        //instance.ReadNext();


    }


    public void ReadNext()
    {
        print("current index: " + currentIndex);
        
        if(currentIndex == currentConvo.GetLength())
        {
            EndDialogue();
            return;
        }

        speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();

        if (_isEndTyping)
        {

            if (typing == null)
            {
                typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
            }
            else
            {
                instance.StopCoroutine(typing);
                typing = null;
                typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
            }
        }
        else
        {
            instance.StopCoroutine(typing);
            typing = null;
            dialogue.text += currentConvo.GetLineByIndex(currentIndex).dialogue.Substring(dialogueIndex);

            // Remove all / characters

            int slashIndex = dialogue.text.IndexOf('/');
            while (slashIndex != -1)
            {
                dialogue.text = dialogue.text.Remove(slashIndex, 1);
                slashIndex = dialogue.text.IndexOf('/');
            }


            //dialogue.text = dialogue.text.Trim(new char[] { '/' });

            _isEndTyping = true;
        }



        speakerSprite1.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains1;
        speakerSprite2.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains2;

        if (_isEndTyping)
        {

            currentIndex++;
        }
       
    }

 
    public void EndDialogue()
    {
        GlobalBools._isBlockTheMovement = false;
        _dialogueBox.SetActive(false);
        currentIndex = 0;
        GlobalBools._isTalking = false;
    }

    private IEnumerator TypeText(string text)
    {

        dialogue.text = "";
        bool complete = false;
        dialogueIndex = 0;
        _isEndTyping = false;

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

        _isEndTyping = true;
        typing = null;
    }
}
