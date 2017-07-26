using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusicScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        BackgroundMusicScript[] backgroundMusicScripts = FindObjectsOfType<BackgroundMusicScript>();
        if (backgroundMusicScripts.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}