using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealSpawn : MonoBehaviour
{

    public GameObject SpawnPoint;

    // Int to track Cereal starting to fall.
    private int gameStartN = 1;

    public float carrotate;

    private GameObject gamerSups;

    //bool pouring = false;
  


    void Start()


    {
       

    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space) ) (0) & carrotate >= 10
        {
            Instantiate {gamerSups,transform.position, Quaterion.identity };

            carrotate = 0;


        }
        if (carrotate < 10)
        {
            carrotate +=
        }
        */

        // Input the space key in order to start the cereal flow 
        if (SpawnPoint.transform.rotation.eulerAngles.z >= 50 & gameStartN >= 1) 
        {
            StartCoroutine("pourcereal");

            gameStartN = 0;
        }
        
    }

    IEnumerator pourcereal()
    {


        


           GameObject prefab = Resources.Load("Cube") as GameObject; //forloop for spawning multiple cubes
            for (int i = 0; i < 250; i++)
            {
            GameObject go = Instantiate(prefab) as GameObject;
            go.transform.localScale = new Vector3(Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f));
            go.transform.position = GameObject.Find("SpawnPoint").transform.position; //setting spawn location 
            yield return new WaitForSeconds(.07f);
            
        }

        


    }




}