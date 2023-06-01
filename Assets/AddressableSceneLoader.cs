using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class AddressableSceneLoader : MonoBehaviour
{
    public AssetReference SceneReference;

    public void LoadAddressableScene()
    {
        Addressables.LoadSceneAsync(SceneReference);
    }

    public void LoadBuiltInScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
