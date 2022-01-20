using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceN2 : MonoBehaviour
{
    public GameObject nPlaced;
    public bool n2Placedtrue;
    public PuzzleManager _PuzzleManager;
    
    // Start is called before the first frame update
    void Start()
    {
        nPlaced.SetActive(false);
        n2Placedtrue = false;
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
            n2Placedtrue = true;

            if (_PuzzleManager.allLettersPlaced)
            {
                Destroy(other.gameObject);
                nPlaced.SetActive(true);
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("N"))
        {
            Debug.Log("N unPlaced");
            n2Placedtrue = false; 
        }
           
    }
}
