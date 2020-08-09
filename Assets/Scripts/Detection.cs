using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Detection : MonoBehaviour
{
    
    public int GameScore = 0;
    public GameObject DetectionBox; //dectection box is used to calculate score 

    void Start()
    {
       

    }

    void Update()
    {
        

    }

    private void OnTriggerEnter()
    {
       print("Something is entering the box"); //when item enters box game score increases by 1
       GameScore++;
        ScoreScript.scoreValue++;
    }

    private void OnTriggerExit() // when something leaves the box came score decreases by 1 these values are updates in scorescript 
    {
       print("Something is exiting the box");
       GameScore--;
        ScoreScript.scoreValue--;

    }

    // Update is called once per frame
    

}
