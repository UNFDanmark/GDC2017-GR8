using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public NavMeshAgent navigationAgent;
    public Figur playerZambieew;


    // Use this for initialization
    void Start()
    {
        playerZambieew = GameObject.FindGameObjectWithTag("Player").GetComponent<Figur>();
        GetComponent<NavMeshAgent>().Warp(transform.position);
        print(transform.position);
    }
    void OnDestroy()
    {
        FindObjectOfType<Zombiespawner>(). zombiesAlive--;
    }
    // Update is called once per frame
    void Update()
    {
        navigationAgent.destination = playerZambieew.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            KillPlayer();
        }
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene("Lose");
    }

}