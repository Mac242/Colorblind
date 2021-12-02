using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Countdown : MonoBehaviour
{
    private float timer;
    public GameObject player;
    public TextMeshProUGUI timerText;

    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;  // counting seconds down
        int minutes = Mathf.FloorToInt(timer / 60f); 
        int seconds = Mathf.FloorToInt(timer % 60f);
        timerText.text =  "Timer: " + string.Format("{0:00}:{1:00}", minutes, seconds); // Display Timer ; Format / Text

        if (timer <= 0)
        {
            Winning();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            timer = 60f;
            player.transform.position = spawnPoint.transform.position;
        }
    }

    void Winning()
    {
        
    }

}
