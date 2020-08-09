using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSpawn : MonoBehaviour
{
    public GameObject cereal;
    public GameObject SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
            //Instantiate(cereal);
            //cereal.transform.position = GameObject.Find("SpawnPoint").transform.position;
        }

        void Spawn()
        {
           
            for(int i = 0; i < 250; i++)
                {
            Instantiate(cereal);
                 }
        }


    }




}

