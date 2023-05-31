using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class ScriptableUnityEventListener : MonoBehaviour
    {
        public UnityEvent Response;
        public ScriptableUnityEvent Event;

        private void OnEnable()
        {
            Event.OnRaised.AddListener(OnScriptableUnityEventRaised);
        }

        private void OnDisable()
        {
            Event.OnRaised.RemoveListener(OnScriptableUnityEventRaised);
        }

        private void OnScriptableUnityEventRaised()
        {
            Response?.Invoke();
        }
    }
}