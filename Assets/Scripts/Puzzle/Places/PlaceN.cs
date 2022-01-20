using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceN : MonoBehaviour
{
    public bool nPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
        nPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("N"))
        {
            Debug.Log("N Placed");
            nPlacedtrue = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("N"))
        {
            Debug.Log("N unPlaced");
            nPlacedtrue = false; 
        }
           
    }
}
