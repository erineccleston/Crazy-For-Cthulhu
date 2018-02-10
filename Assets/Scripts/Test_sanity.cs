using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_sanity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SanityUp()
    {
        sanity_bar.UpdateSanity(10f);
    }

    public void SanityDown()
    {
        sanity_bar.UpdateSanity(-10f);
    }
}
