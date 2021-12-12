using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = System.Random;


public class Countdown : MonoBehaviour
{
    public float timer;
    public GameObject player;
    public TextMeshProUGUI timerText;
    public bool collision;

    // Start is called before the first frame update
    void Start()
    {
        timer = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // counting seconds down
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        timerText.text = "Timer: " + string.Format("{0:00}:{1:00}", minutes, seconds); // Display Timer ; Format / Text

        if (timer <= 0)
        {
            Winning();
        }
        
        if (collision == true)
        {
            Gamepad.current.SetMotorSpeeds(0.5f, 1f);
        }
        else
        {
            Gamepad.current.SetMotorSpeeds(0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
             timer = 90f;
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

    void Winning()
    {
        
    }

}
