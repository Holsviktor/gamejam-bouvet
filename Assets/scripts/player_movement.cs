using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float forceMultiplier = 200;
    float max_speed = 5f, acceleration = 1.1f;
    float xVelocity = 0f, zVelocity = 0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        max_speed = 2;        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (rb.transform.position.y != 0.99)
        {
            GetComponent<Rigidbody>().position = 0.99;
        } */
         // Sjekk input
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
