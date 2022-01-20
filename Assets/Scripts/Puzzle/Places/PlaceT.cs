using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceT : MonoBehaviour
{
    public bool tPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        tPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("T"))
        {
            Debug.Log("T Placed");
            tPlacedtrue = true;
            
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("T"))
        {
            Debug.Log("T unPlaced");
            tPlacedtrue = false; 
        }
           
    }
}
