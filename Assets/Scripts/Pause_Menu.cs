using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject pauseMenu;

    public bool gameIsPaused;

    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        gameIsPaused = false;
        scene = SceneManager.GetActiveScene().buildIndex;
        
    }

    private void Update()
    {
        Cursor.visible = true;
        if ( gameIsPaused==false && Input.GetKey(KeyCode.Joystick1Button13))
        {
            Time.timeScale = 0;
            Debug.Log("Pause!");
            pauseMenu.SetActive(true);
            gameIsPaused = true;
           
            
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

    public void RestartLevel()
    {
        SceneManager.LoadScene(scene);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
