using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceO : MonoBehaviour
{
    public bool oPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
        oPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("O"))
        {
            Debug.Log("O Placed");
            oPlacedtrue = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("O"))
        {
            Debug.Log("O unPlaced");
            oPlacedtrue = false; 
        }
           
    }
            
}
