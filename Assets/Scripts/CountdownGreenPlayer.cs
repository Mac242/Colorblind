using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CountdownGreenPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject _Countdown;
    public bool collision;
    
    
    // Start is called before the first frame update
    void Start()
    {
        collision = false;
    }

    private void Update()
    {
        if (collision == true)
        {
            Gamepad.current.SetMotorSpeeds(0.5f, 1f);
        }
        else
        {
            Gamepad.current.SetMotorSpeeds(0, 0);
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _Countdown.GetComponent<Countdown>().timer = 90f;
            collision = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            collision = false;
        }
    }
}
