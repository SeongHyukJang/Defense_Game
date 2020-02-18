using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WaveSpawner : MonoBehaviour
{
    GameObject[] Enemy;

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public static int enemyCount = 0;

    public float timeBetweenWaves = 20F; // 5F
    private float countdown = 2f;

    private int waveNumber = 0;
    private int waveIndex = 20;

    public const int life = 40; // 10
    public Text LifeCountText;
    public Text RoundCountText;
    public Text waveCountdownText;

    void Update()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount = Enemy.Length;

        if (countdown <= 0f || enemyCount == 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();

        LifeCountText.text = (life - enemyCount).ToString();

        if (countdown >= 0f && (life - enemyCount) < 0)
        {
            Destroy(gameObject);
        }
    }

  

    IEnumerator SpawnWave ()
    {
        waveNumber++;
        RoundCountText.text = (waveNumber).ToString();

        for (int i = 0; i < waveIndex; i++)
        {
            enemyCount++;
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
