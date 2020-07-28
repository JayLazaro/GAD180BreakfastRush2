using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Detection : MonoBehaviour
{
    
    public int GameScore = 0;
    public GameObject DetectionBox;

    void Start()
    {
       

    }

    void Update()
    {
        

    }

    private void OnTriggerEnter()
    {
       print("Something is entering the box");
       GameScore++;
    }

    private void OnTriggerExit()
    {
       print("Something is exiting the box");
       GameScore--;
       
    }

    // Update is called once per frame
    

}
