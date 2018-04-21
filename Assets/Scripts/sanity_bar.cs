using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sanity_bar : MonoBehaviour
{

    public static float Sanity = 50;

    // Use this for initialization
    void Start()
    {
        GameObject sanityBar = GameObject.Find("SanityFill");

        Image fillImage = sanityBar.gameObject.GetComponent<Image>();

        fillImage.transform.localScale += new Vector3(15f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Updates sanity with a given float.
    /// </summary>
    /// <param name="modifier">added to sanity</param>
    public static void UpdateSanity(float modifier)
    {
        GameObject sanityBar = GameObject.Find("SanityFill");

        Image fillImage = sanityBar.gameObject.GetComponent<Image>();
        Sanity += modifier;

        fillImage.transform.localScale += new Vector3(modifier * 0.3f, 0f, 0f);


        if (Sanity <= 0f)
        {
            Sanity = 0f;
            fillImage.transform.localScale = new Vector3(0f, 0f, 0f);
        }
        if (Sanity >= 100f)
        {
            Sanity = 100f;
            fillImage.transform.localScale = new Vector3(35f, 0f, 0f);
        }
    }
}
