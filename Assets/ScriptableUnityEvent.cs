using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    [CreateAssetMenu(menuName = "ScriptableUnityEvent")]
    public class ScriptableUnityEvent : ScriptableObject
    {
        public UnityEvent OnRaised;
    }
}