using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceE : MonoBehaviour
{
   
    public GameObject ePlaced;
    public bool ePlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        ePlaced.SetActive(false);
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

            if (_PuzzleManager.allLettersPlaced == true)
            {
                Destroy(other.gameObject);
                ePlaced.SetActive(true);
            }
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
