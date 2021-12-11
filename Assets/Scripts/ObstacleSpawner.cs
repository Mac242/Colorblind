using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    
    public float spawnRate = 3f;
    public float spawnDelay = 1f;

    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void Spawn()
    {
        GameObject clone = Instantiate(obstacles[Random.Range(0,2)], new Vector3(Random.Range(minX, maxX), Random.Range(minY,maxY), 0 ), Quaternion.identity);
        Destroy(clone, 15f);
    }

 
 
 
 
 
 
  
  
  
   
}
