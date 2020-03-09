using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWithSkill : MonoBehaviour
{
    private static float explosionRadius;
    private static int damage;


    public static void ActivateSkill(SkillEffect _skill_effect, GameObject _enemy)
    {
        if(_skill_effect.Skill_ID != 1007)
        {
            GameObject ImpactEffect = (GameObject)Instantiate(_skill_effect.Skill_Effect, _enemy.transform.position, Quaternion.Euler(-70, 0, 0));
            Destroy(ImpactEffect, 2f);
        }
        explosionRadius = _skill_effect.Radius;
        damage = _skill_effect.Damage;

        if(explosionRadius > 0f)
        {
            Explode(_enemy.transform);
            _skill_effect.ExtraSkillEffects();
        }
        else
        {
            _skill_effect.ExtraSkillEffects();
            Damage(_enemy.transform);
        }
    }

    static void Explode(Transform enemy)
    {
        Collider[] colliders = Physics.OverlapSphere(enemy.position, explosionRadius);
        foreach(Collider collider in colliders)
        {
            if(collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    static void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if(e != null)
        {
            e.TakeDamage(damage);
        }
    }
    
}
