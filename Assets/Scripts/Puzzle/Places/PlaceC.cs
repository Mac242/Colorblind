using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceC : MonoBehaviour
{
    
    public GameObject cPlaced;
    public bool cPlacedtrue;
    
    // Start is called before the first frame update
    void Start()
    {
        cPlaced.SetActive(false);
        cPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("C"))
        {
            Debug.Log("C Placed");
            Destroy(other.gameObject);
            cPlaced.SetActive(true);
            cPlacedtrue = true;
        }
    }
}
