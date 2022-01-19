using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceO : MonoBehaviour
{
    
    public GameObject oPlaced;
    public bool oPlacedtrue;
    
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
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("O"))
        {
            Debug.Log("C Placed");
            Destroy(other.gameObject);
            oPlaced.SetActive(true);
            oPlacedtrue = true;
        }
    }
}
