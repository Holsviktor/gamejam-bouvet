using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    // Start is called before the first frame update
 	public float speed = 20f;
	public float minDist = 1f;
	private Transform target;
    private GameObject player;

	// Use this for initialization
	void Start() 
	{
        player = GameObject.Find("Player");
        if (player != null)
        {
            target = player.GetComponent<Transform>();
        }
	}
	
	// Update is called once per frame
	void Update() 
	{
		if (target == null)
			return;

		transform.LookAt(target);

		float distance = Vector3.Distance(transform.position,target.position);

		if(distance > minDist)	
			transform.position += transform.forward * speed * Time.deltaTime;	
	}

	// Set the target of the chaser
	public void SetTarget(Transform newTarget)
	{
		target = newTarget;
	}

  
}
