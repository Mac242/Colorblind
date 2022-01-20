using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour

{
    void Start()
    {
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("1_Scene_Begin to Play_easy");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}


