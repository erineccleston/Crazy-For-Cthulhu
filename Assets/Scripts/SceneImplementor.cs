using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneImplementorScript : MonoBehaviour
{
    static GameObject GameOverInsane;
    static GameObject GameOverSane;

    // Use this for initialization
    void Start()
    {
        //set all objects to toggle as false then
        //selectively change later
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
    }
    //functions to manager scene and
    //cause proper toggles
    //implemented here to keep things tidy

    //Main Manager
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
        GameOverInsane.SetActive(true);
        
    }

    public static void FullSanityManager()
    {
        GameOverSane.SetActive(true);
    }
    //Animation Pose manager
    public static void CookingPoseManager()
    {

    }
    public static void SexyRunwayPose()
    {

    }
    public static void SadPose()
    {

    }
    public static void BlushPose()
    {

    }
    public static void NeutralPose()
    {

    }
}
