using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    //public GameObject tower;
    public int moneyGain = 100;
    public float speed = 10f;

    public float startHealth = 100;

    private float meetSpeed = 10f;

    private Transform target;
    private float health;

    public Image healthBar;
    private int waypointCount = 0;
    public float defense = 0f;

    void Start()
    {
        target = Waypoints.points[0];

        //transform.Rotate(0, 228.461539f, 0);
        

        health = startHealth;
    }
    
    void Update()
    {
        
        //transform.RotateAround(tower.transform.position, Vector3.down, speed*Time.deltaTime );
        //transform.position += transform.forward * speed * Time.deltaTime;
        //transform.Rotate(0f, -1f, 0f);

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        //Enemy look Foward. Reference youtuber Brackeys.
        // And message pops
        if (dir != Vector3.zero)
        {
            Quaternion enemyLook = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(transform.rotation, enemyLook, Time.deltaTime * meetSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }
        
        

        if (Vector3.Distance(transform.position, target.position) <= 0.3f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (waypointCount == Waypoints.points.Length - 1)
        {
            waypointCount = 1;
            target = Waypoints.points[waypointCount];
            waypointCount++;
            defense++;
        }
        else
        {
            waypointCount++;
            target = Waypoints.points[waypointCount];
        }
        //transform.Rotate(0, -13.846153f, 0);
    }

    public void TakeDamage(float amount)
    {
        //health -= amount;

        // 피해량 = 데미지(amount) + 100 / (100+방어력)
        health -= amount * 100 / (100 + defense);

        healthBar.fillAmount = health / startHealth;

        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += moneyGain;
        Destroy(gameObject);
    }

    
}
