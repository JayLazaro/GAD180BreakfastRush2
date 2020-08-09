using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealSpawn : MonoBehaviour
{

    public GameObject SpawnPoint;

    //bool pouring = false;
  


    void Start()


    {
       

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("pourcereal");
        }

    }

    IEnumerator pourcereal()
    {


        


           GameObject prefab = Resources.Load("Cube") as GameObject; //forloop for spawning multiple cubes
            for (int i = 0; i < 250; i++)
            {
            GameObject go = Instantiate(prefab) as GameObject;
            go.transform.position = GameObject.Find("SpawnPoint").transform.position; //setting spawn location 
            yield return new WaitForSeconds(.07f);
           
        }

        


    }




}