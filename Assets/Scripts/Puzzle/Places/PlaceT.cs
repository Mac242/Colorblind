using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceT : MonoBehaviour
{
   
    public GameObject tPlaced;
    public bool tPlacedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        tPlaced.SetActive(false);
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

            if (_PuzzleManager.allLettersPlaced == true)
            {
                Destroy(other.gameObject);
                tPlaced.SetActive(true);
            }
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
