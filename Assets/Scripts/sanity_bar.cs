using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sanity_bar : MonoBehaviour
{

    public static float Sanity;
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
            fillImage.transform.localScale += new Vector3(Sanity, 0f, 0f);
            updated = false;
        }
    }

    /// <summary>
    /// Updates sanity with a given float.
    /// </summary>
    /// <param name="modifier">added to sanity</param>
    public void UpdateSanity(float modifier)
    {
        Sanity += (modifier * 0.3f);

        if (Sanity <= 0)
            Sanity = 0;
        if (Sanity >= 30)
            Sanity = 30;

        updated = true;
    }
}
