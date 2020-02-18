
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public GameObject WaveSpawner;
    public float speed = 4f;
    public int def = 0;

    private bool flag = true;
    private Transform target;
    private int wavepointIndex = 0;
    //private int checkpoint = 0;

    void Start()
    {
        target = WayPoints.points[0];
        transform.Rotate(0, 180, 0);
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
         
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();

        }

        
    }

    void GetNextWaypoint()
    {
        if (!(flag) && target == WayPoints.points[0])
        {
            def++;
        }

        if (flag)
        {
            flag = false;
            wavepointIndex++;
            target = WayPoints.points[wavepointIndex];
        }
        
        else if (wavepointIndex == 3)
        {
            
            transform.Rotate(0, -90, 0);
            wavepointIndex = 0;
            target = WayPoints.points[wavepointIndex];
        }
        else // wavepointIndex = 0, 1, 2
        {
            transform.Rotate(0, -90, 0);
            wavepointIndex++;
            target = WayPoints.points[wavepointIndex];
        }

        
    }

    public void OnDestroy()
    {
        
    }

}
