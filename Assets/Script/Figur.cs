using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Figur : MonoBehaviour
{
    public float moveSpeed = 20f;
    public Rigidbody myRigidbody;
    public float rotationSpeed = 10;
    public GameObject torso;
    public GameObject lArm;
    public GameObject rArm;
    public GameObject head;
    public AudioSource background;
    public KeyCode attackButton = KeyCode.Space;
    public Killboks killBoks;
    public AudioSource myAudio;
    public AudioClip Walkingsound;
    public AudioSource Punchingsound, Attack;
    public float cooldown;
    public float timer;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        transform.Rotate(0, rotationSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);

        if (Input.GetKey(attackButton) && timer <= 0)
        {           
            timer = cooldown;
            if (killBoks.gameObject.activeInHierarchy == false)
            {
                Attack.Play();
                killBoks.gameObject.SetActive(true); 
            }

        }
    }
    void FixedUpdate()
    {
        Move(moveSpeed * Input.GetAxis("Vertical"));
    }
    void Move(float speed)
    {
        myRigidbody.velocity = transform.forward * speed + Vector3.up * myRigidbody.velocity.y;
    }






    //Item Statements
public void Torso(GameObject pickUpBody)
    {
        pickUpBody.SetActive(false);
        torso.SetActive(true);
    }
    public void Head(GameObject pickUpBody)
    {
        pickUpBody.SetActive(false);
        head.SetActive(true);
    }
    public void LArm(GameObject pickUpBody)
    {
        pickUpBody.SetActive(false);
        lArm.SetActive(true);
    }
    public void RArm(GameObject pickUpBody)
    {
        pickUpBody.SetActive(false);
        rArm.SetActive(true);
    }
   
   

    //Item Pickup
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Torso"))
        {
            Torso(collider.gameObject);
        }
        if (collider.CompareTag("Head"))
        {
            Head(collider.gameObject);
        }
        if (collider.CompareTag("L arm"))
        {
            LArm(collider.gameObject);
        }
        if (collider.CompareTag("R arm"))
        {
            RArm(collider.gameObject);
        }
    }

    public void TakeDamage() {
        if (head.activeSelf)
        {
            head.SetActive(false);
            return;
        }

        if (lArm.activeSelf)
        {
            lArm.SetActive(false);
            return;
        }

        if (rArm.activeSelf)
        {
            rArm.SetActive(false);
            return;
        }
        if (torso.activeSelf == true)
        {
            torso.SetActive(false);
            return;
        }

        SceneManager.LoadScene("Lose");
    }
}