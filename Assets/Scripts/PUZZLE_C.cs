using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUZZLE_C : MonoBehaviour
{
    public Transform parent;
    public PolygonCollider2D top;
    public PolygonCollider2D bottom;
    public PolygonCollider2D complete;

    // Start is called before the first frame update
    void Start()
    {
        top.enabled = true;
        bottom.enabled = true;
        complete.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("C"))
        {
            Debug.Log("C Created");
            transform.SetParent(parent);
            top.enabled = false;
            bottom.enabled = false;
            complete.enabled = true;
        }
    }
}
