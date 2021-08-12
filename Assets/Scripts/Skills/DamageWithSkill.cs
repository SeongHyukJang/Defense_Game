using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWithSkill : MonoBehaviour
{
    private static float explosionRadius;
    private static float damage;


    public static void ActivateSkill(SkillEffect _skill_effect, GameObject _enemy)
    {
        explosionRadius = _skill_effect.Radius;
        damage = _skill_effect.Damage;

        if (explosionRadius > 0f)
        {
            GameObject ImpactEffect = (GameObject)Instantiate(_skill_effect.Skill_Effect, _enemy.transform.position, Quaternion.Euler(-70, 0, 0));
            Destroy(ImpactEffect, 2f);

            Explode(_enemy.transform, _skill_effect);
        }
        //else
        //{
        //    _skill_effect.ExtraSkillEffects();
        //    Damage(_enemy.transform);
        //}
    }

    static void Explode(Transform enemy, SkillEffect _skill_effect)
    {
        Collider[] colliders = Physics.OverlapSphere(enemy.position, explosionRadius);
        foreach(Collider collider in colliders)
        {
            if(collider.tag == "Enemy")
            {
                Damage(collider.transform, _skill_effect);
            }
        }
    }

    static void Damage(Transform enemy, SkillEffect _skill_effect)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if(e != null)
        {
            _skill_effect.ExtraSkillEffects(e, damage);
        }
    }
    
}
