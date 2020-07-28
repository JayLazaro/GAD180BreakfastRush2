using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour{

    public Text scoreText;

    
    
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Detection>().GameScore = GameScore.ToString();
       
        //scoreText = gameObject.GetComponent<Detection>().GameScore;
    }

    // Update is called once per frame
    void Update()
    {
       // scoreText.text = "Score: " + GameScore;
    }
}

