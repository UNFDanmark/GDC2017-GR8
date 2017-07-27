using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Zombiespawner : MonoBehaviour
{
    public int nextWave = 1;
    public int zombiesAlive = 0;
    public GameObject zombiePrefab;
    public AudioSource zombieSpawn;
    public Text wave;

    public void SpawnWave()
    {
        int zombiesToSpawn = (int)Mathf.Pow(2, nextWave);
        for(int i = 0; i < zombiesToSpawn; i++)
        {
            Vector3 zPos = new Vector3(Random.Range(-95, 64), -3, Random.Range (-89, 84));
            Instantiate(zombiePrefab, zPos, transform.rotation);
            zombiePrefab.GetComponent<NavMeshAgent>().Warp(zPos);
                zombiesAlive++;
        }
        zombieSpawn.Play();
        wave.text = "Wave: " + (nextWave);
    }

    // Use this for initialization
    void Start ()
    {
        SpawnWave();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (zombiesAlive == 0)
        {
            nextWave++;
            SpawnWave();
        }
        print(zombiesAlive); 
	}
}
