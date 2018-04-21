using UnityEngine;

public class DialogueNode : ScriptableObject
{
    public string Name;
    [TextArea]
    public string Dialogue;
    public GameEvents Event;
    public Link[] Choices;

    [System.Serializable]
    public struct Link
    {
        [TextArea]
        public string Response;
        [Range(0, 100)]
        public float SanityLowest;
        [Range(0, 100)]
        public float SanityHighest;
        public float SanityChange;
        public DialogueNode Next;
    }
}

public enum GameEvents
{
    None,
    EndPrologue1,
    EndPrologue2,
    EndPrologue3,
    EndPrologue4,
    EndPrologue5,
    EndPrologue6,
    EndPrologue7,
    EndPrologue8,
    EndPrologue9,
    EndPrologue10,
    EndIntro,
    EndMeeting,
    EndDate1,
    EndDate2,
    EndDate3,
    EndFullInsanity,
    EndFullSanity
}
