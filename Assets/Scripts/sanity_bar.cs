using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sanity_bar : MonoBehaviour
{

    public static float sanity;
    private bool updated = false;

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
        GameObject sanityBar = GameObject.Find("SanityFill");

        Image fillImage = sanityBar.gameObject.GetComponent<Image>();
        if (updated)
        {
            fillImage.transform.localScale += new Vector3(sanity, 0f, 0f);
            updated = false;
        }
    }

    /// <summary>
    /// Updates sanity with a given float.
    /// </summary>
    /// <param name="modifier">Max value 30</param>
    public void UpdateSanity(float modifier)
    {
        sanity += modifier;

        if (sanity <= 0)
            sanity = 0;
        if (sanity == 30)
            sanity = 30;

        updated = true;
    }
}
