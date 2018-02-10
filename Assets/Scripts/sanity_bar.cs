using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanity_bar : MonoBehaviour {

    public static float sanity;

    /// <summary>
    /// Updates sanity depending on the choice's sanity modifier
    /// </summary>
    public void UpdateSanity(float updater)
    {
        sanity += updater;
    }
}
