using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Retry()
    {
        SceneManager.LoadScene("Zambie Collector");

    }
}