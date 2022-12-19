using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

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
        Cursor.visible = false;
        
        if (pauseMenu.activeInHierarchy)
        {
            Debug.Log("Pause!");
            gameIsPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            gameIsPaused = false;
            Time.timeScale = 1;
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
