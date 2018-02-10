using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    
    public Queue<string> sentences;
    GameObject dateName = GameObject.Find("dateName");

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();

	}

    public void beginConversation(DialogueNode node)
    {
        Debug.Log("starting conversation");
        dateName.GetComponent<Text>().text = node.Name;
        string[] lines = node.Dialogue.Split('\n');
        foreach (string line in lines)
        {
            sentences.Enqueue(line);
        }

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

    private void displaySentence(string v)
    {
        throw new NotImplementedException();
    }

    private void presentChoice()
    {
        throw new NotImplementedException();
    }
}
