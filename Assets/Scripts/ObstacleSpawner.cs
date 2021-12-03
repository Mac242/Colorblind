using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    
    public float spawnRate = 5f;
    public float spawnDelay = 5f;

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
        for (int i = 0; i< obstacles.Length; i++)
        {
            GameObject clone = Instantiate(obstacles[i], new Vector3(Random.Range(minX, maxX),Random.Range(minY, maxY), 0), Quaternion.identity);
            Destroy(clone, 10f);
        }
        
    }
    
}
