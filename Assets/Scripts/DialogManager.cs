using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    
    public Queue<string> sentences;
    GameObject dateName;
    GameObject dateWords;
    GameObject yourName;
    GameObject dialogueBox;
    GameObject opt1;
    GameObject opt2;
    GameObject opt3;
    GameObject opt4;

    public DialogueNode StartNode;
    private DialogueNode CurrentNode;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
        dateName = GameObject.Find("dateName");
        dateWords = GameObject.Find("dateWords");
        yourName = GameObject.Find("yourName");
        dialogueBox = GameObject.Find("dialogBox");
        opt1 = GameObject.Find("option1");
        opt2 = GameObject.Find("option2");
        opt3 = GameObject.Find("option3");
        opt4 = GameObject.Find("option4");

        CurrentNode = StartNode;
        beginConversation();
	}

    public void beginConversation()
    {
        Debug.Log("starting conversation");
        //shows the date's words and name
        dateName.SetActive(true);
        dateWords.SetActive(true);
        //conceals your name and choices
        yourName.SetActive(false);
        opt1.SetActive(false);
        opt2.SetActive(false);
        opt3.SetActive(false);
        opt4.SetActive(false);

        dateName.GetComponent<Text>().text = CurrentNode.Name;
        string[] lines = CurrentNode.Dialogue.Split('\n');
        foreach(string line in lines)
        {
            sentences.Enqueue(line);
        }

        goToNextSentence();
    }

    public void goToNextSentence()
    {
        if(sentences.Count == 0)
        {
            presentChoice();
        } else
        {
            displaySentence(sentences.Dequeue()); 
        }
    }

    private void displaySentence(string currentLine)
    {
        dateWords.GetComponent<Text>().text = currentLine;
    }

    public void presentChoice()
    {
        //hides the date's words and name and dialogue "next sentence" button.
        dateName.SetActive(false);
        dateWords.SetActive(false);
        dialogueBox.GetComponent<Button>().interactable = false;

        //shows your name and choices, diables invalid choices.
        yourName.SetActive(true);
        for(int i = 0; i < CurrentNode.Choices.Length; i++)
        {
            if (i == 0)
            {
                opt1.GetComponent<Text>().text = CurrentNode.Choices[i].Response;
                opt1.SetActive(true);
                if (sanity_bar.Sanity < CurrentNode.Choices[i].SanityHighest && sanity_bar.Sanity > CurrentNode.Choices[i].SanityLowest)
                {
                    opt1.GetComponent<Button>().interactable = true;
                }
                else
                {
                    opt1.GetComponent<Button>().interactable = false;
                }
            }

            if (i == 1)
            {
                opt2.GetComponent<Text>().text = CurrentNode.Choices[i].Response;
                opt2.SetActive(true);
                if (sanity_bar.Sanity < CurrentNode.Choices[i].SanityHighest && sanity_bar.Sanity > CurrentNode.Choices[i].SanityLowest)
                {
                    opt2.GetComponent<Button>().interactable = true;
                } else
                {
                    opt2.GetComponent<Button>().interactable = false;
                }
                
            }

            if (i == 2)
            {
                opt3.GetComponent<Text>().text = CurrentNode.Choices[i].Response;
                opt3.SetActive(true);
                if (sanity_bar.Sanity < CurrentNode.Choices[i].SanityHighest && sanity_bar.Sanity > CurrentNode.Choices[i].SanityLowest)
                {
                    opt3.GetComponent<Button>().interactable = true;
                }
                else
                {
                    opt3.GetComponent<Button>().interactable = false;
                }
            }

            if (i == 3)
            {
                opt4.GetComponent<Text>().text = CurrentNode.Choices[i].Response;
                opt4.SetActive(true);
                if (sanity_bar.Sanity < CurrentNode.Choices[i].SanityHighest && sanity_bar.Sanity > CurrentNode.Choices[i].SanityLowest)
                {
                    opt4.GetComponent<Button>().interactable = true;
                }
                else
                {
                    opt4.GetComponent<Button>().interactable = false;
                }
            }
        }
    }

    public void registerChoice(int choice)
    {
        //changes sanity
        sanity_bar.UpdateSanity(CurrentNode.Choices[choice].SanityChange);
        CurrentNode = CurrentNode.Choices[choice].Next;
        beginConversation();
    }
}
