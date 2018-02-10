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
    GameObject opt1;
    GameObject opt2;
    GameObject opt3;
    GameObject opt4;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
         dateName = GameObject.Find("dateName");
         dateWords = GameObject.Find("dateWords");
         yourName = GameObject.Find("yourName");
         opt1 = GameObject.Find("option1");
         opt2 = GameObject.Find("option2");
         opt3 = GameObject.Find("option3");
         opt4 = GameObject.Find("option4");
	}

    public void beginConversation(DialogueNode node)
    {
        Debug.Log("starting conversation");
        //shows the date's words and name
        dateName.SetActive(true);
        dateWords.SetActive(true);

        dateName.GetComponent<Text>().text = node.Name;
        string[] lines = node.Dialogue.Split('\n');
        foreach(string line in lines)
        {
            sentences.Enqueue(line);
        }

    }

    public void goToNextSentence(DialogueNode node)
    {
        if(sentences.Count == 0)
        {
            presentChoice(node);
        } else
        {
            displaySentence(sentences.Dequeue()); 
        }
    }

    private void displaySentence(string currentLine)
    {
        dateWords.GetComponent<Text>().text = currentLine;
    }

    private void presentChoice(DialogueNode node)
    {
        //hides the date's words and name
        dateName.SetActive(false);
        dateWords.SetActive(false);

        //shows your name and choices
        yourName.SetActive(true);
        for(int i = 0; i < node.Choices.Length; i++)
        {
            if (i == 0)
                opt1.GetComponent<Text>().text = node.Choices[i].Response;
                opt1.SetActive(true);
            if (i == 2)
                opt2.GetComponent<Text>().text = node.Choices[i].Response;
                opt2.SetActive(true);
            if (i == 2)
                opt3.GetComponent<Text>().text = node.Choices[i].Response;
                opt3.SetActive(true);
            if (i == 3)
                opt4.GetComponent<Text>().text = node.Choices[i].Response;
                opt4.SetActive(true);
        }
    }
}
