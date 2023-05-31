using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageLabelController : MonoBehaviour
{
    public TextMeshProUGUI Label;

    private void Start()
    {
        Label.text =
            "This Unity projects demonstrates how ScriptableObjects may behave unexpectedly on a build vs. inside the editor. Spawning cubes will increment the count in the editor, but not on a build.\n\n"+
            $"Current Platform: {GetPlatformString()}";
    }

    private string GetPlatformString()
    {
#if UNITY_EDITOR
        return "EDITOR";
#elif UNITY_ANDROID
        return "ANDROID";
#else 
        return "OTHER PLATFORM"; // didn't have the other platforms installed
#endif
    }
}
