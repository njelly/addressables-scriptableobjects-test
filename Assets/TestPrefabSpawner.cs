using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DefaultNamespace
{
    public class TestPrefabSpawner : MonoBehaviour
    {
        public AssetReference PrefabAssetReference;
        public GameObject Prefab;
        
        [Header("Spawn Pattern")]
        public float Radius;
        public float AngleDelta;

        private float _angle;

        public void SpawnFromAssetReference()
        {
            PrefabAssetReference.InstantiateAsync(GetPos(), Quaternion.identity);
        }

        public void SpawnFromPrefab()
        {
            Instantiate(Prefab, GetPos(), Quaternion.identity, null);
        }

        private Vector3 GetPos()
        {
            var center = new Vector3(0f, 0f, Radius);
            var pos = Quaternion.Euler(0f, _angle, 0f) * (Vector3.zero - center) + Vector3.forward * Radius;
            _angle += AngleDelta;
            return pos;
        }
    }
}