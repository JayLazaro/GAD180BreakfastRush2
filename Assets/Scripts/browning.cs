using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class browning : MonoBehaviour
{
    public Material yellow;
    public Material brown;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter (Collider Col)
    {
        if (Col.gameObject.tag == "fire")
        {
            this.gameObject.GetComponent<MeshRenderer>().material = brown;
        }
    }
    
}
