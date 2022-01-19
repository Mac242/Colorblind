using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceN : MonoBehaviour
{
    public GameObject nPlaced;
    public bool nPlacedtrue;
    
    // Start is called before the first frame update
    void Start()
    {
        nPlaced.SetActive(false);
        nPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("N"))
        {
            Debug.Log("N Placed");
            Destroy(other.gameObject);
            nPlaced.SetActive(true);
            nPlacedtrue = true;
        }
    }
}
