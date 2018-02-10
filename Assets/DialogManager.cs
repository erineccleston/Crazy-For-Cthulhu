using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {

    public Queue<string> sentences;


	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
	}
	
	
}
