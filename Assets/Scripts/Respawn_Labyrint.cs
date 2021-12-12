using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Respawn_Labyrint : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    [SerializeField] int numberOfAllowedCollisions;
    
    void Start()
    {
        numberOfAllowedCollisions = 3;
    }

    void Update()
    {
        if (numberOfAllowedCollisions <= 0)
        {
            player1.transform.position = spawnPoint1.transform.position;
            player2.transform.position = spawnPoint2.transform.position;
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
