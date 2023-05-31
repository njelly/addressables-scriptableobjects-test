using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using ScriptableEvents.Events;
using UnityEngine;

public class TestPrefab : MonoBehaviour
{
    public SimpleScriptableEvent PrefabSpawned;
    public ScriptableUnityEvent UnityEventPrefabSpawned;

    private void Start()
    {
        PrefabSpawned.Raise();
        UnityEventPrefabSpawned.OnRaised?.Invoke();
    }
}
