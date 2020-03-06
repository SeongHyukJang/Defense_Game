using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GManager : MonoBehaviour
{
    private bool GameEnded = false;
    void Update()
    {
        if (GameEnded) { return; }

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameEnded = true;
        Debug.Log("Game Over");
    }
}
