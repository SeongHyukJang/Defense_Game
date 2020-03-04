using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public Transform enemy;

    

    void Update()
    {

        transform.position = enemy.position + new Vector3(0, 5, 0);
        transform.LookAt(new Vector3(9.26f, 8.88f,-58.3f));
        //transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0);
    }

}