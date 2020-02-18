using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    bool Paused;
    public GameObject menu;

    public void setPause()
    {
        if (!Paused)
        {
            Paused = true;
            Time.timeScale = 0f;
            menu.SetActive(true);

        }
    }

    public void setContinue()
    {
        if (Paused)
        {
            Paused = false;
            Time.timeScale = 1f;
            menu.SetActive(false);
        }
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
