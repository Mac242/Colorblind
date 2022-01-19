using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceI : MonoBehaviour
{
    
    public GameObject iPlaced;
    public bool iPlacedtrue;
    
    // Start is called before the first frame update
    void Start()
    {
        iPlaced.SetActive(false);
        iPlacedtrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("I_Finish"))
        {
            Debug.Log("C Placed");
            Destroy(other.gameObject);
            iPlaced.SetActive(true);
            iPlacedtrue = true;
        }
    }
}
