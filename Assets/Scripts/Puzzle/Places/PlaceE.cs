using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceE : MonoBehaviour
{
   
    public GameObject ePlaced;
    public bool ePlacedtrue;
    
    // Start is called before the first frame update
    void Start()
    {
        ePlaced.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ePlacedtrue = false;
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("E"))
        {
            Debug.Log("C Placed");
            Destroy(other.gameObject);
            ePlaced.SetActive(true);
            ePlacedtrue = true;
        }
    }
}
