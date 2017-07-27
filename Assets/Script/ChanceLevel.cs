using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChanceLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextLevel() {
        SceneManager.LoadScene(1);
    }
}
