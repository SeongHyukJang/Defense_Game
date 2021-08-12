using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    
    public Transform enemyPrefab1;
    public Transform enemyPrefab1Boss;
    public Transform enemyPrefab2;
    public Transform enemyPrefab2Boss;
    public Transform enemyPrefab3;
    public Transform enemyPrefab3Boss;
    public Transform enemyPrefab4;
    public Transform enemyPrefab4Boss;
    /*public Transform enemyPrefab7;
    public Transform enemyPrefab8;
    public Transform enemyPrefab9;*/
    //public Transform[] enemyPrefab = { enemy1, enemy2 };
    public Transform spawnPoint;

    private float timeBetweenWaves = 40f; // 1f
    private float countdown = 10f; // 40f Prepare Skill before Game Start
    
    private int waveNumber = 0;
    private int waveIndex = 20; //2

    public Text RoundCountText;
    public Text waveCountdownText;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        else if (LivesUI.enemyCount == 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }
    IEnumerator SpawnWave ()
    {
        waveNumber++;
        TextFadeIn.FadeIn(waveNumber);
        RoundCountText.text = (waveNumber).ToString();

        switch (waveNumber)
        {
            case 10:
                Instantiate(enemyPrefab1Boss, spawnPoint.position, spawnPoint.rotation);
                break;
            case 20:
                Instantiate(enemyPrefab2Boss, spawnPoint.position, spawnPoint.rotation);
                break;
            case 30:
                Instantiate(enemyPrefab3Boss, spawnPoint.position, spawnPoint.rotation);
                break;
            case 40:
                Instantiate(enemyPrefab4Boss, spawnPoint.position, spawnPoint.rotation);
                break;
            default:
                break;
        }
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        if (0 < waveNumber && waveNumber <= 10)
        {
            Instantiate(enemyPrefab1, spawnPoint.position, spawnPoint.rotation);

        }

        else if (10 < waveNumber && waveNumber <= 20)
        {
            Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);
        }

        else if (20 < waveNumber && waveNumber <= 30)
        {
            Instantiate(enemyPrefab3, spawnPoint.position, spawnPoint.rotation);
        }

        else if (30 < waveNumber && waveNumber <= 40)
        {
            Instantiate(enemyPrefab4, spawnPoint.position, spawnPoint.rotation);
        }
        /*switch (waveNumber)
        {
            case 1:
                Instantiate(enemyPrefab1, spawnPoint.position, spawnPoint.rotation);
                break;
            case 2:
                Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);
                break;
            default:
                break;
        }*/

    }

}
