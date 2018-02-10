using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {

    
    public Queue<string> sentences;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();

	}

    public void beginConversation(DialogueNode)
    {
        Debug.Log("starting conversation");
        dateName.Text = 
        string[] lines = dialog.Split('\n');
        foreach (string line in lines)
        {
            sentences.Enqueue(line);
        }

    }

    public void goToNextSentence()
    {
        if(sentences.Count == 0)
        {
            
        }
    }


	
	
}
