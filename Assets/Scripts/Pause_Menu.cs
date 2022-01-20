using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject pauseMenu;

    public bool gameIsPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        gameIsPaused = false;
    }

    private void Update()
    {
        if ( gameIsPaused==false && Input.GetKey(KeyCode.Joystick1Button13))
        {
            Time.timeScale = 0;
            Debug.Log("PauseMenue");
            pauseMenu.SetActive(true);
            gameIsPaused = true;
            Cursor.visible = true;
            
            if (gameIsPaused==true && Input.GetKey(KeyCode.Joystick1Button13))
            {
                PlayGame();
            }
        }

        
    }

    
    public void PlayGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
