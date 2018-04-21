using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneImplementorScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject gameOverInsane = GameObject.Find("GameOverInsane");
        GameObject gameOverSane = GameObject.Find("GameOverSane");
    }
    // Update is called once per frame
    void Update()
    {

    }

    //functions to manager scene and
    //cause proper toggles
    //implemented here to keep things tidy
    public static void IntroManager()
    {
        
    }

    public static void MeetingManager()
    {

    }

    public static void Date1Manager()
    {

    }

    public static void Date2Manager()
    {

    }

    public static void Date3Manager()
    {

    }

    public static void FullInsanityManager()
    {
        //GameOver.;
        
    }

    public static void FullSanityManager()
    {

    }
}
