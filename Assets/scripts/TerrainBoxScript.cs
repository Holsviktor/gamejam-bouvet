using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBoxScript : MonoBehaviour
{
    private Transform target;
    private GameObject player;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* void OnCollisionEnter(Collision collision)
    {
        enemy = GameObject.Find("Enemy");
        player = GameObject.Find("Player");
        if (player != null)
        {
            target = player.GetComponent<Transform>();
        }
        enemy.GetComponent<enemy_movement>().SetTarget(target);
        

        // Check if the collided object has a specific tag or name (optional)
        if (collision.gameObject.CompareTag("Player1"))
        {
            Debug.Log("Entity has moved onto the floor.");

            // Add your logic here for when the entity moves onto the floor
        }

    } */

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            target = player.transform;
            
            // Find all enemies within the terrain box and assign them the target
            foreach (Transform enemy in transform)
            {
                enemy_movement enemyMovement = enemy.GetComponent<enemy_movement>();
                if (enemyMovement != null)
                {
                    enemyMovement.SetTarget(target);
                }
            }
        }
    }
}
