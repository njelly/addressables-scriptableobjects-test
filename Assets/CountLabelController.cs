using ScriptableEvents.Events;
using TMPro;
using UnityEngine;

public class CountLabelController : MonoBehaviour
{
    public TextMeshProUGUI Label;

    private int _count;

    private void Awake()
    {
        SetLabelText();
    }

    public void IncrementCount()
    {
        _count++;
        SetLabelText();
    }

    private void SetLabelText()
    {
        Label.text = $"Count: {_count}";
    }
}
