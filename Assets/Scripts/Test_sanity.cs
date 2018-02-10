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
        Debug.Log(sanity_bar.Sanity);
    }

    public void SanityDown()
    {
        sanity_bar.UpdateSanity(-10f);
        Debug.Log(sanity_bar.Sanity);
    }
}
