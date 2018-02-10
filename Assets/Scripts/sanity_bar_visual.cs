using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sanity_bar_visual : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject sanityBar = GameObject.Find("SanityFill");
      
        Image fillImage = sanityBar.gameObject.GetComponent<Image>();

        fillImage.transform.localScale += new Vector3(30f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sanityBar = GameObject.Find("SanityFill");

        Image fillImage = sanityBar.gameObject.GetComponent<Image>();

        //fillImage.transform.localScale += new Vector3(10f, 0f, 0f);
    }
}
