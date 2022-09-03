using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    public Canvas dialogueCanvas;
    public TMP_Text nameText; 
    public TMP_Text dialogueText;

    public Button dialogueButton; 

    private Queue<string> sentences;
    public GameObject doorOne; 



    // Start is called before the first frame update
    void Start()
    {
       
        dialogueButton.onClick.AddListener(DisplayNextSentence);
        dialogueCanvas.gameObject.SetActive(false);
        sentences = new Queue<string>(); 
    }

    public void StartDialogue(Dialogue dialogue){

        dialogueCanvas.gameObject.SetActive(true);

        nameText.text = dialogue.name; 

        sentences.Clear(); 

        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
            DisplayNextSentence();
    }
    public void DisplayNextSentence(){
        if(sentences.Count == 0){
            EndDialogue();
            return; 
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }
    void EndDialogue(){
        dialogueCanvas.gameObject.SetActive(false);
        doorOne.gameObject.SetActive(false);
    }

}
