using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneImplementorScript : MonoBehaviour
{
    static GameObject GameOverInsane;
    static GameObject GameOverSane;
    static GameObject Cthullu_Flipping_Off;
    
    //static GameObject introSequence1 = GameObject.Find("introSequence1");
    //static GameObject introSequence2 = GameObject.Find("introSequence2");
    //static GameObject introSequence3 = GameObject.Find("introSequence3");
    //static GameObject introSequence4 = GameObject.Find("introSequence4");
    //static GameObject introSequence5 = GameObject.Find("introSequence5");
    //static GameObject introSequence6 = GameObject.Find("introSequence6");
    //static GameObject introSequence7 = GameObject.Find("introSequence7");
    //static GameObject introSequence8 = GameObject.Find("introSequence8");
    //static GameObject introSequence9 = GameObject.Find("introSequence9");
    //static GameObject introSequenceParent = GameObject.Find("introSequenceParent");

    // Use this for initialization
    void Start()
    {
        GameOverInsane = GameObject.Find("GameOverInsane");
        GameOverSane = GameObject.Find("GameOverSane");
        Cthullu_Flipping_Off = GameObject.Find("Cthullu_Flipping_Off");

        //set all objects to toggle as false then
        //selectively change later
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);

    }
    //functions to manager scene and
    //cause proper toggles
    //implemented here to keep things tidy

    //Main Manager
    public static void IntroManager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void MeetingManager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void Date1Manager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void Date2Manager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void Date3Manager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void FullInsanityManager()
    {
        //true
        GameOverInsane.SetActive(true);
        //retoggle all false
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);

    }

    public static void FullSanityManager()
    {
        //retoggle false
        GameOverInsane.SetActive(false);
        //toggle true
        GameOverSane.SetActive(true);
        //retoggle false
        Cthullu_Flipping_Off.SetActive(false);
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
