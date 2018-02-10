using UnityEngine;
using UnityEditor;

public class DialogueNodeAsset
{
    [MenuItem("Assets/Create Dialogue Node")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<DialogueNode>();
    }
}