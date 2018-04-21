 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ignore this lowercase notice
public class sceneryManager : MonoBehaviour
{
    //have to call the scene implentor for each function
    //we want to use
    public SceneImplementorScript IntroManager;
    public SceneImplementorScript MeetingManager;
    public SceneImplementorScript Date1Manager;
    public SceneImplementorScript Date2Manager;
    public SceneImplementorScript Date3Manager;
    public SceneImplementorScript FullInsanityManager;
    public SceneImplementorScript FullSanityManager;
    public void EventHappened(GameEvents gameEvent)
    {
        switch (gameEvent)
        {
            case GameEvents.EndPrologue1:
                break;
            case GameEvents.EndPrologue2:
                break;
            case GameEvents.EndPrologue3:
                break;
            
            case GameEvents.EndIntro:
                SceneImplementorScript.IntroManager();
                break;

            case GameEvents.EndMeeting:
                SceneImplementorScript.MeetingManager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndDate1:
                SceneImplementorScript.Date1Manager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndDate2:
                SceneImplementorScript.Date2Manager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndDate3:
                SceneImplementorScript.Date3Manager();
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;

            case GameEvents.EndFullInsanity:
                SceneImplementorScript.FullInsanityManager();
                //write
                //bring up menu
                //pause game
                break;

            case GameEvents.EndFullSanity:
                SceneImplementorScript.FullSanityManager();
                //write
                //bring up menu
                //pause game
                break;

            //case GameEvents.EndNeutral;
        }
    }
}
