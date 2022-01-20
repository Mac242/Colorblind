using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceC : MonoBehaviour
{
    public bool cPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        cPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("C"))
        {
            Debug.Log("C Placed");
            cPlacedtrue = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("C"))
        {
            Debug.Log("C unPlaced");
            cPlacedtrue = false; 
        }
           
    }
}
