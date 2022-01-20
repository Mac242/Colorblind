using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceO : MonoBehaviour
{
    
    public GameObject oPlaced;
    public bool oPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        oPlaced.SetActive(false);
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
            
            if (_PuzzleManager.allLettersPlaced == true)
            {
                Destroy(other.gameObject);
                oPlaced.SetActive(true);
            }
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
