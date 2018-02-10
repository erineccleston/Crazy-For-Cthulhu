using UnityEngine;

public class DialogueNode : ScriptableObject
{
    [TextArea]
    public string Dialogue;
    public float SanityChange;
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
        public DialogueNode Next;
    }
}
