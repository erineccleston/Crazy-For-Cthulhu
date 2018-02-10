using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                break;
        }
    }
}
