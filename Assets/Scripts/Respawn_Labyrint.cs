using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class Respawn_Labyrint : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    [SerializeField] private GameObject lives2;
    [SerializeField] private GameObject lives1;
    [SerializeField] int numberOfAllowedCollisions;
    
    void Start()
    {
        numberOfAllowedCollisions = 3;
    }

    void Update()
    {
        if (numberOfAllowedCollisions <= 0)
        {
            player1.transform.position = spawnPoint1.transform.position;
            player2.transform.position = spawnPoint2.transform.position;
            numberOfAllowedCollisions = 3;
        }

        if (numberOfAllowedCollisions == 3)
        {
            lives2.SetActive(false);
            lives1.SetActive(false);
        }
        
        if (numberOfAllowedCollisions == 2)
        {
            lives2.SetActive(true);
        }

        if (numberOfAllowedCollisions == 1)
        {
            lives1.SetActive(true);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Respawn") && gameObject == player1)
        {
            //Gamepad.current.SetMotorSpeeds(.5f, .8f);
            numberOfAllowedCollisions -= 1;
            Debug.Log("Collision Player 1");
        }
        
        if (col.gameObject.CompareTag("Respawn") && gameObject == player2)
        {
            //Gamepad.current.SetMotorSpeeds(.5f, .8f);
            numberOfAllowedCollisions -= 1;
            Debug.Log("Collision Player 2");
        }
        
        
    }
    
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Respawn") && gameObject== player1)
        {
            //Gamepad.current.SetMotorSpeeds(0f, 0f);
        }
        
        if (col.gameObject.CompareTag("Respawn") && gameObject== player2)
        {
           // Gamepad.current.SetMotorSpeeds(0f, 0f);
        }
    }
}
