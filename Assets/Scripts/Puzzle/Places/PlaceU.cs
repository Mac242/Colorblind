using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceU : MonoBehaviour
{
    public bool uPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        uPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("U"))
        {
            Debug.Log("U Placed");
            uPlacedtrue = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("U"))
        {
            Debug.Log("U unPlaced");
            uPlacedtrue = false; 
        }
           
    }
}
