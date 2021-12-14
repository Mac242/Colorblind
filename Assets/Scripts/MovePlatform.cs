using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject playerRed;
    public GameObject playerGreen;

    
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerRed)
        {
            playerRed.transform.parent = transform;
        }
        if (other.gameObject == playerGreen)
        {
            playerGreen.transform.parent = transform;
        }
            
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == playerRed)
        {
            playerRed.transform.parent = null;
        }
        if (other.gameObject == playerGreen)
        {
            playerGreen.transform.parent = null;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
