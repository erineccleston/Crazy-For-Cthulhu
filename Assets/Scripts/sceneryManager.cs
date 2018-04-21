 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneryManager : MonoBehaviour
{
    public void EventHappened(GameEvents gameEvent)
    {
        switch (gameEvent)
        {
            case GameEvents.EndIntro:
                break;
            case GameEvents.EndMeeting:

                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;
            case GameEvents.EndDate1:
                
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;
            case GameEvents.EndDate2:
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;
            case GameEvents.EndDate3:
                sanity_bar.dateStartSanity = sanity_bar.Sanity;
                break;
            case GameEvents.EndFullInsanity:
                //{
                //    SceneManager.LoadScene("GameOverInsane", LoadSceneMode.Single);
                //}

                //write
                //bring up menu
                //pause game
                break;
            case GameEvents.EndFullSanity:
                // {
                //    SceneManager.LoadScene("GameOverSane", LoadSceneMode.Single);
                // }

                //write
                //bring up menu
                //pause game
                break;
            //case GameEvents.EndNeutral;
        }
    }
}
