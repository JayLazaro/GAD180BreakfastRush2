using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlMove : MonoBehaviour
{
    int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Makes the bowl move back and forth along the bench.
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 5), transform.position.y, transform.position.z);
    }

       
}
