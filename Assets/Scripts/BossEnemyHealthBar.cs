using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyHealthBar : MonoBehaviour
{
    public Transform enemy;
    
    void LateUpdate()
    {
        transform.position = enemy.position + new Vector3(0,10,0);
        transform.LookAt(new Vector3(8.5f,6.5f,-60f));
        //transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0);
    }

}