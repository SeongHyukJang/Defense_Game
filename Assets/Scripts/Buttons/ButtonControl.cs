using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject menu;

    
    public void setPause()
    {
        if (!Paused)
        {
            menu.SetActive(true);
            Time.timeScale = 0f;
            Paused = true;
        }
    }

    public void setContinue()
    {
        if (Paused)
        {
            menu.SetActive(false);
            Time.timeScale = 1f;
            Paused = false;
        }
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1f;
        Paused = false;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 0f;
    }
}
