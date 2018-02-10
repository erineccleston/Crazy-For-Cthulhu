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
    EndIntro
}
