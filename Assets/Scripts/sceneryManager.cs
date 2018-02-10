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
                break;
            case GameEvents.EndDate1:
                break;
            case GameEvents.EndDate2:
                break;
            case GameEvents.EndFullInsanity:
                {
                    SceneManager.LoadScene("GameOverInsane", LoadSceneMode.Single);
                }
                break;
        }
    }
}
