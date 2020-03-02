using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public Transform enemy;
    void Update()
    {
        transform.position = enemy.position + new Vector3(0,5,0);   
    }
    
}
