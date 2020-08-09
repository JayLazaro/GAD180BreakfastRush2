using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{


    public static int scoreValue = 0;
    Text score;



    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>(); //geting component text
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue + " / 250"; //score.text is the string score + the score value then string "scoreValue
        




    }
}
