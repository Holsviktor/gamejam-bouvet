using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    // Start is called before the first frame update
 	private float speed = 5f;
	private float minDist = 1f;
	private Transform target;
    private GameObject player;
    private GameObject currentFlag;

	// Use this for initialization
	void Start() 
	{
        /* player = GameObject.Find("Player");
        if (player != null)
        {
            target = player.GetComponent<Transform>();
        } */
        GameObject[] flags = GameObject.FindGameObjectsWithTag("flag");
        currentFlag = flags[0];
        for (GameObject flag in flags) {
            float currentDistance = Vector3.Distance(transform.position, currentFlag.transform.position);
            float newDistance = Vector3.Distance(transform.position, flag.transform.position);
            if (newDistance < currentDistance) [
                currentFlag = flag;
            ]
        }
	}
	
	// Update is called once per frame
	void Update() 
	{
		if (target == null)
			return;

        // Check if the enemy is within the terrain box
        /* if (terrainCollider != null && !terrainCollider.bounds.Contains(transform.position))
        {
            return; // Do not move if outside bounds
        } */

        float PlayerFlagDistance = Vector3.Distance(player.transform.position, currentFlag.transform.position);
        if (PlayerFlagDistance < 10) {
            transform.LookAt(target);

            float distance = Vector3.Distance(transform.position,target.position);

            if(distance > minDist)	
                transform.position += transform.forward * speed * Time.deltaTime;
        }

	}

	// Set the target of the chaser
	public void SetTarget(Transform newTarget)
	{
		target = newTarget;
	}

  
}
