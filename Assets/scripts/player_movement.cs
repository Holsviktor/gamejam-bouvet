using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    float max_speed = 5f, acceleration = 0.1f;
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
        max_speed = 2;
    }

    private void FixedUpdate()
    {
        // Sjekk input
        if (Input.GetKeyDown(KeyCode.W))
        {
            zVelocity += acceleration;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            xVelocity += acceleration;
        }
        // Bestem bevegelse

        if (Input.GetKeyDown(KeyCode.S))
        {
            zVelocity -= acceleration;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            xVelocity -= acceleration;
        }

        //rb.addForce(transform)

    }
}
