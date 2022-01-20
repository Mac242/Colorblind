using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceE : MonoBehaviour
{
    public bool ePlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        ePlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("E"))
        {
            Debug.Log("E Placed");
            ePlacedtrue = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("E"))
        {
            Debug.Log("E unPlaced");
            ePlacedtrue = false; 
        }
           
    }
}
