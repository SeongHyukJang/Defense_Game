using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    GameObject[] Enemy;

    public Transform enemyPrefab;
    public Text livesText;

    public static int enemyCount = 0;
    


    void Update()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount = Enemy.Length;

        livesText.text = (PlayerStats.Lives - enemyCount).ToString();
    }
}
