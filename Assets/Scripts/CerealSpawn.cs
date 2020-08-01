using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealSpawn : MonoBehaviour
{

    public GameObject SpawnPoint;

    void Start()


    {
        StartCoroutine(coroutine());

    }


    IEnumerator coroutine()
    {



        GameObject prefab = Resources.Load("Cube") as GameObject;
        for (int i = 0; i < 250; i++)
        {
            GameObject go = Instantiate(prefab) as GameObject;
            go.transform.position = GameObject.Find("SpawnPoint").transform.position;
            yield return new WaitForSeconds(.06f);
        }


    }




}