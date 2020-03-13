using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public static bool Skill1007 = false;
    public float explosionRadius = 0f;
    public float speed = 70f;
    public GameObject impactEffect;
    private GameObject skill_effect;
    public float damage = 50;

    void Start()
    {
        skill_effect = Resources.Load("Skill Effects/1007", typeof(GameObject)) as GameObject;
    }
    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
        
    }
    void HitTarget()
    {
        if(Skill1007)
        {
            GameObject _skill_effect = (GameObject)Instantiate(skill_effect, transform.position + new Vector3(0,4,0), transform.rotation);
            damage *= 2f;
        }
        else
        {
            damage *= 0.5f;
        }
        else
        {
            damage *= 0.5f;
        }
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        
        if(explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }

        Destroy(gameObject);

    }
    // 범위 뎀
    void Explode()
    {
        
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    // 단일 뎀
    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();
        
        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
