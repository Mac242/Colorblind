using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceU : MonoBehaviour
{
    public GameObject uPlaced;
    public bool uPlacedtrue;
    
    // Start is called before the first frame update
    void Start()
    {
        uPlaced.SetActive(false);
        uPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("U"))
        {
            Debug.Log("C Placed");
            Destroy(other.gameObject);
            uPlaced.SetActive(true);
            uPlacedtrue = true;
        }
    }
}
