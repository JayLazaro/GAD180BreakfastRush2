using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //key"E" is used to load the environment 'maytheforth' and score script with score value set at 0
        {

            Application.LoadLevel("may the forth");
            ScoreScript.scoreValue=0;
        }


    }
}