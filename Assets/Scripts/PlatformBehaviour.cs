﻿using UnityEngine;
using System.Collections;

public class PlatformBehaviour : MonoBehaviour
{
    /* A simple script that allows the road to be endless
     * 
     * In the Update() function the z position is checked if it has surpassed
     * 0 and/or destroyDistance. 
     * 
     * When a piece of road reaches 0, a new road is instantiated
     * from the array of roads. 
     * 
     * When it surpasses destroyDistance, it is behind the player
     * where it can no longer be seen and the gameobject is destroyed.
     * */
    public GameObject[] roads;
    public bool repeatSpawning = false;
    public float destroyDistance;
    
    private bool spawnedNew = false;
	
	// Update is called once per frame
	void Update ()
    {
        if(repeatSpawning)
        {   
            if (transform.position.z < 0 && spawnedNew != true)
            {
                Instantiate(roads[Random.Range(0, roads.Length -1)], new Vector3(0, 0, 59), Quaternion.identity);
                spawnedNew = true;
            }
        }

        if(transform.position.z < destroyDistance)
        {
            Destroy(this.gameObject);
            
        }
	}
}
