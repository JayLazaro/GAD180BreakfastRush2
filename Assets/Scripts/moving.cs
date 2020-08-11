using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 leftPosition;

    private Vector3 rightPosition;
    public Vector3 targetPosition;
    private int speed = 3;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Moves the GameObject using it's transform.
        rb.isKinematic = true;

        leftPosition = new Vector3(1, 1, -1);
        rightPosition = new Vector3(4, 1, -1);
        targetPosition = leftPosition;
        
    }




    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {


        // Moves the GameObject to the left of the origin.
     if (transform.position.x > 3.9f) // if x less than 3, x position is 1 
       {
            targetPosition = leftPosition;
       }


        if (transform.position.x < 1.1f)
        {
            targetPosition = rightPosition; 
        }

        targetPosition = new Vector3(targetPosition.x, transform.position.y, transform.position.z);

        rb.MovePosition(Vector3.Lerp (transform.position, targetPosition, 1f * Time.deltaTime));




    }



}
