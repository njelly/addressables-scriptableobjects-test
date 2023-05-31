using System.Collections;
using System.Collections.Generic;
using ScriptableEvents.Events;
using UnityEngine;

public class TestPrefab : MonoBehaviour
{
    public SimpleScriptableEvent PrefabSpawned;

    private void Start()
    {
        PrefabSpawned.Raise();
    }
}
