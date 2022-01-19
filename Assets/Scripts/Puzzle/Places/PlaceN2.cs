using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceN2 : MonoBehaviour
{
    public GameObject nPlaced;
    public bool n2Placedtrue;
    
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
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("N"))
        {
            Debug.Log("N Placed");
            Destroy(other.gameObject);
            nPlaced.SetActive(true);
            n2Placedtrue = true;
        }
    }
}
