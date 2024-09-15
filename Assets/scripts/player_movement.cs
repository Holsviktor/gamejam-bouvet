using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float forceMultiplier = 200;
    float max_speed = 5f, acceleration = 1.1f;
    float xVelocity = 0f, zVelocity = 0f;
    Rigidbody rb;

    private GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        max_speed = 2;
        floor = GameObject.Find("floor");
    }

    // Update is called once per frame
    void Update()
    {
        /* if (rb.transform.position.y != 0.99)
        {
            GetComponent<Rigidbody>().position = 0.99;
        } */
         // Sjekk input
        /* var floorTransform = floor.GetComponent<Transform>();
        float floorDistance = Vector3.Distance(transform.position, floor.transform.position); */
        if (transform.position.x > 50) {
            transform.position = new Vector3(50, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -50) {
            transform.position = new Vector3(-50, transform.position.y, transform.position.z);
        }
        if (transform.position.z > 50) {
            transform.position = new Vector3(transform.position.x, 50, transform.position.z);
        }
        if (transform.position.z < -50) {
            transform.position = new Vector3(transform.position.x, -50, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            zVelocity += acceleration;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            xVelocity -= acceleration;
        }
        // Bestem bevegelse

        if (Input.GetKey(KeyCode.S))
        {
            zVelocity -= acceleration;
        }

        if (Input.GetKey(KeyCode.D))
        {
            xVelocity += acceleration;
        }
        if (xVelocity < -max_speed)
        {
            xVelocity = -max_speed;
        }
        if (xVelocity > max_speed)
        {
            xVelocity = max_speed;
        }
        
        if (zVelocity < -max_speed)
        {
            zVelocity = -max_speed;
        }
        if (zVelocity > max_speed)
        {
            zVelocity = max_speed;
        }
        rb.AddForce(new Vector3(xVelocity * forceMultiplier, 0, zVelocity * forceMultiplier));
    }

    private void FixedUpdate()
    {
       

    }
}
