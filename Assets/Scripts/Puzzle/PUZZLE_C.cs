using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUZZLE_C : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;
    public GameObject complete;
    public bool completed;

    // Start is called before the first frame update
    void Start()
    {
        complete.SetActive(false);
        top.SetActive(true);
        bottom.SetActive(true);
        completed = false;
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
            complete.SetActive(true);
            top.SetActive(false);
            bottom.SetActive(false);
            completed = true;
        }
    }

    
}
