 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ignore this lowercase notice
public class sceneryManager : MonoBehaviour
{
    //have to call the scene implentor for each function
    //we want to use

    static GameObject SceneImplementorManager;

    static GameObject introSequence1;
    static GameObject introSequence2;
    static GameObject introSequence3;
    static GameObject introSequence4;
    static GameObject introSequence5;
    static GameObject introSequence6;
    static GameObject introSequence7;
    static GameObject introSequence8;
    static GameObject introSequence9;
    static GameObject introSequenceParent;

    private void Awake()
    {
        SceneImplementorManager = GameObject.Find("SceneImplementorManager");
        introSequence1 = GameObject.Find("introSequence1");
        introSequence2 = GameObject.Find("introSequence2");
        introSequence3 = GameObject.Find("introSequence3");
        introSequence4 = GameObject.Find("introSequence4");
        introSequence5 = GameObject.Find("introSequence5");
        introSequence6 = GameObject.Find("introSequence6");
        introSequence7 = GameObject.Find("introSequence7");
        introSequence8 = GameObject.Find("introSequence8");
        introSequence9 = GameObject.Find("introSequence9");
        introSequenceParent = GameObject.Find("introSequenceParent");
    }
    public void EventHappened(GameEvents gameEvent)
    {
        switch (gameEvent)
        {
            //Prologue
            //case GameEvents.EndPrologue1:
            //    introSequenceParent.SetActive(true);
            //    introSequence1.SetActive(true);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue2:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(true);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue3:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(true);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue4:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(true);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue5:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(true);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue6:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(true);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue7:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(true);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue8:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(true);
            //    introSequence9.SetActive(false);
            //    break;

            //case GameEvents.EndPrologue9:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(true);
            //    break;

            //case GameEvents.EndPrologue10:
            //    introSequence1.SetActive(false);
            //    introSequence2.SetActive(false);
            //    introSequence3.SetActive(false);
            //    introSequence4.SetActive(false);
            //    introSequence5.SetActive(false);
            //    introSequence6.SetActive(false);
            //    introSequence7.SetActive(false);
            //    introSequence8.SetActive(false);
            //    introSequence9.SetActive(false);
            //    introSequenceParent.SetActive(true);
            //    break;

            //Main Events
            case GameEvents.EndIntro:
                
                SceneImplementor.IntroManager();
                break;

            case GameEvents.EndMeeting:
                SceneImplementor.MeetingManager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndDate1:
                SceneImplementor.Date1Manager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndDate2:
                SceneImplementor.Date2Manager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndDate3:
                SceneImplementor.Date3Manager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;
            //Animation Events
            case GameEvents.EndCookingPose:
                SceneImplementor.CookingPoseManager();
                break;

            //Game over events
            case GameEvents.EndFullInsanity:
                SceneImplementor.FullInsanityManager();
                break;

            case GameEvents.EndFullSanity:
                SceneImplementor.FullSanityManager();
               
                break;

            //case GameEvents.EndNeutral;
        }
    }
}
