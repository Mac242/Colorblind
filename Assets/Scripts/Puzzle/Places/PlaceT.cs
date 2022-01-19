using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceT : MonoBehaviour
{
   
    public GameObject tPlaced;
    public bool tPlacedtrue;
    
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
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("T"))
        {
            Debug.Log("T Placed");
            Destroy(other.gameObject);
            tPlaced.SetActive(true);
            tPlacedtrue = true;
        }
    }
}
