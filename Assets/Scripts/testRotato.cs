using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRotato : MonoBehaviour
{

    public Rigidbody rb3d;

    public int rotato;


    void Awake()
    {
        rb3d = GetComponent<Rigidbody>();

        rotato = 0;
    }

    void Update()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            //Adding force, pushing left
            rb3d.AddForce(-0.5f, 0f, 0f);
            //Code for action on mouse moving left
            print("Mouse moved left");
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //Adding force, pushing right
            rb3d.AddForce(0.5f, 0f, 0f);
            //Code for action on mouse moving right
            print("Mouse moved right");
        }
        if (Input.GetAxis("Mouse Y") < 0)
        {
            //Adding Force, pushing down
            rb3d.AddForce(0f, -0.5f, 0f);
            //Code for action on mouse moving left
            print("Mouse moved down");
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            //Adding Force, pushing up
            rb3d.AddForce(0f, 0.5f, 0f);
            //Code for action on mouse moving right
            print("Mouse moved up");
        }


        //Rotation Code, Used to Rotate Box
        if (Input.GetKey(KeyCode.Space) & rotato <= 0)
        {
            rb3d.AddTorque(0f, 0f, 0.5f);
        }
        
        if (Input.GetKey(KeyCode.Space) & rotato >= 1)
        {
            rb3d.AddTorque(0f, 0f, -0.5f);
        }
        
        
    }
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space) & rotato <= 0)
        {
            rotato = 0;
        }
        if (Input.GetKeyUp(KeyCode.Space) & rotato >= 1)
        {
            rotato = 0;
        }
    }
}
