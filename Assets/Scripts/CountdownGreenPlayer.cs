using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CountdownGreenPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject _Countdown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
       
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _Countdown.GetComponent<Countdown>().timer = 90f;
        }
    }

    
}
