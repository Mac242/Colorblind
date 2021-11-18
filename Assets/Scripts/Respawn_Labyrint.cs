using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Labyrint : MonoBehaviour
{
    public GameObject player;
    public Transform SpawnPoint;
    [SerializeField] int numberOfAllowedCollisions;
    
    void Start()
    {
        numberOfAllowedCollisions = 3;
    }

    void Update()
    {
        if (numberOfAllowedCollisions <= 0)
        {
            player.transform.position = SpawnPoint.transform.position;
            numberOfAllowedCollisions = 3;

        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Respawn"))
        {
            numberOfAllowedCollisions -= 1;
            Debug.Log("Collision");
        }
        
    }
}
