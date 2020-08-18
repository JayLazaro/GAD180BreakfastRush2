using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scales : MonoBehaviour
{
    private GameObject cube;
    
    private Vector3 scaleChange;

    void start()
    {
     
   

    }

    void Update()
    {


        Renderer rend = cube.GetComponent<Renderer>();
        rend.material = Resources.Load<Material>("blue");

        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        //scaleChange = new Vector3(-Random.Range, -0.01f, -0.01f); 
        cube.transform.localScale = scaleChange;
        
    }
}

