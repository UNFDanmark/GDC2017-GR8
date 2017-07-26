using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Killboks : MonoBehaviour
{

    public Rigidbody Zambieew;
    public float lifeTime;
    public float time;
    public GameObject torsoPrefab;
    public GameObject larmPrefab;
    public GameObject rarmPrefab;
    public GameObject headPrefab;
    public int torsoDropLikelyhood;
    public int larmDropLikelyhood;
    public int rarmDropLikelyhood;
    public int headDropLikelyhood;

    void Awake()
    {
        Zambieew = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            Destroy(collider.gameObject);
            
            int spawnNumber = Random.Range(0, 100);
            if (spawnNumber < torsoDropLikelyhood)
            {
                GameObject torso = Instantiate(torsoPrefab);
                torso.transform.position = collider.gameObject.transform.position;
            }

            int spawnNumber2 = Random.Range(0, 100);
            if (spawnNumber2 < larmDropLikelyhood)
            {
                GameObject larm = Instantiate(larmPrefab);
                larm.transform.position = collider.gameObject.transform.position;
            }

            int spawnNumber3 = Random.Range(0, 100);
            if (spawnNumber3 < rarmDropLikelyhood)
            {
                GameObject rarm = Instantiate(rarmPrefab);
                rarm.transform.position = collider.gameObject.transform.position;
            }

            int spawnNumber4 = Random.Range(0, 100);
            if (spawnNumber4 < headDropLikelyhood)
            {
                GameObject head = Instantiate(headPrefab);
                head.transform.position = collider.gameObject.transform.position;
            }
            
        }
    }
    void OnEnable()
    {
        time = 0f;
    }

}