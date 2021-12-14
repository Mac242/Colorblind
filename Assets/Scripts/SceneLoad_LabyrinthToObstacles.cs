using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad_LabyrinthToObstacles : MonoBehaviour
{
    [SerializeField] GameObject playerRed;
    [SerializeField] GameObject playerGreen;
    private bool greenIn;
    private bool redIn;
	
    // Start is called before the first frame update
    void Start()
    {
        greenIn = false;
        redIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerGreen)
        {
            Debug.Log("GreenIn");
            greenIn = true;
        }
	    
        if (other.gameObject == playerRed)
        {
            Debug.Log("redIn");
            redIn = true;
        }

        if (greenIn == true && redIn == true)
        {
            SceneManager.LoadScene("Scene_Obstacles_Survive");
        }
    }
}