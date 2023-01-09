using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite1;
    public Image speakerSprite2;

    [SerializeField]private int currentIndex;
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Coroutine typing;

    [SerializeField] float _betweenLettersWaitTime;

    [SerializeField] GameObject _dialogueBox;

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
        EventManager.DialogueEnded.AddListener(EndBoolTest);

        
        
    }

    public static void StartConversation(Conversation convo)
    {
       
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";

        instance.ReadNext();


    }


    public void ReadNext()
    {
        
        if(currentIndex >= currentConvo.GetLength())
        {
            
            //EventManager.DialogueEnded.Invoke();
            return;
        }

        speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();

        if(typing == null)
        {
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }
        else
        {
            instance.StopCoroutine(typing);
            typing = null;
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }
       
        speakerSprite1.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains1;
        speakerSprite2.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains2;
        
       

        print("current convo step: " + (currentIndex + 1) + " / " + currentConvo.GetLength());


        if(currentIndex == currentConvo.GetLength() - 1)
        {
            
            print("setting _isDialoguesLastLine to true");

            EventManager.DialogueEnded.Invoke();
            //navButtonText.text = "x";
        }

        currentIndex++;
    }

    private void EndBoolTest()
    {
        if (!GlobalBools._isDialoguesLastLine)
        {

            GlobalBools._isDialoguesLastLine = true;
        }
        else
        {
            GlobalBools._isDialoguesLastLine = false;
        }
    }
    public void EndDialogue()
    {
        _dialogueBox.SetActive(false);
        print("dialog box set to not active");
        currentIndex = 0;
        GlobalBools._isWaitingForInteractue = false;
        GlobalBools._isTalking = false;

        currentIndex = 0;
    }

    private IEnumerator TypeText(string text)
    {

        dialogue.text = "";
        bool complete = false;
        int index = 0;

        while(!complete)
        {
            if (text[index] != '/')
                dialogue.text += text[index];
            index++;
            yield return new WaitForSeconds(_betweenLettersWaitTime);

            if(index == text.Length)
            {
                complete = true;
            }
        }

        typing = null;
    }
}
