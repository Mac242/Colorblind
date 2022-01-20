using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceI : MonoBehaviour
{
    
    public GameObject iPlaced;
    public bool iPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        iPlaced.SetActive(false);
        iPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("I"))
        {
            Debug.Log("I Placed");
            iPlacedtrue = true;

            if (_PuzzleManager.allLettersPlaced == true)
            {
                Destroy(other.gameObject);
                iPlaced.SetActive(true);
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("I"))
        {
            Debug.Log("I unPlaced");
            iPlacedtrue = false; 
        }
           
    }
}
