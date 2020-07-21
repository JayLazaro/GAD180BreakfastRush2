using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRotato : MonoBehaviour
{

    public Rigidbody rb3d;
    void Awake()
    {
        rb3d = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            rb3d.AddForce(-0.1f, 0f, 0f);
            //Code for action on mouse moving left
            print("Mouse moved left");
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            rb3d.AddForce(0.1f, 0f, 0f);
            //Code for action on mouse moving right
            print("Mouse moved right");
        }
        if (Input.GetAxis("Mouse Y") < 0)
        {
            rb3d.AddForce(0f, -0.1f, 0f);
            //Code for action on mouse moving left
            print("Mouse moved down");
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            rb3d.AddForce(0f, 0.1f, 0f);
            //Code for action on mouse moving right
            print("Mouse moved up");
        }
    }
}
