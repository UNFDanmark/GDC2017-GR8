using UnityEngine;
using System.Collections;

public class pointsHandeler : MonoBehaviour {

    public int points = 0;
    //public Text pointsText;

    // Use this for initialization
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int pointsAdd)
    {
        points += pointsAdd;

        //pointsText.text = "Points: " + points;
    }
}
