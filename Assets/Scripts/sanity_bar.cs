using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanity_bar : MonoBehaviour {

    public float maxSanity = 100;
    public static float sanity;
    public float sanityBarLength;

    //Initial sanity bar
    public void StartSanity(float updater)
    {
        sanityBarLength = 0;
    }

    /// <summary>
    /// Updates sanity depending on the choice's sanity modifier
    /// </summary>
    public void UpdateSanity(float updater)
    {
        sanity += updater;

        //if (sanity < 0)
            //game over

<<<<<<< HEAD
        if (sanity > maxSanity) {
                //game over
            }
=======
        //if (sanity > maxSanity)
            //game over
>>>>>>> a77cfc6b21ce5d7adc52c606a2fd638644cf5018

    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, sanityBarLength, 20), sanity + "/" + maxSanity);
    }

}
