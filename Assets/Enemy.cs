
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = WayPoints.points[0];
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
        if (wavepointIndex >= WayPoints.points.Length - 1)
        {
            //todo: 적 방어력 1 증
        }

        if (wavepointIndex == 4)
        {
            wavepointIndex = 0;
            target = WayPoints.points[wavepointIndex];
        }
        else
        {
            wavepointIndex++;
            target = WayPoints.points[wavepointIndex];
        }
    }

}
