using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tower : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]

    public float range = 20f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    [Header("Unity Setup Fields")]

    public string enemyTag = "Enemy";

    public Transform PartToRotate;
    public float turnSpeed = 10f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    private int Activate_Skill_Prob = 0;

    
    private SkillEffect _Skill_Effect;
    public static List<Image> Available_Skill_Image_List = new List<Image>();
    private List<SkillEffect> Skill_Effects_List;

    GameObject enemy = null;


    void Start()
    {
        Skill_Effects_List = DataBaseManager.skillEffects;
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        if(enemies.Length != 0)
        {
            enemy = enemies[0];
        }

        if (enemy != null)
        {
            target = enemy.transform;
        }
        else
        {
            target = null;
        }
    }
    void Update()
    {
        if(target == null) { return; }

        // target lock on
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(PartToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        //Vector3 rotation = lookRotation.eulerAngles;
        PartToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        Activate_Skill_Prob = Random.Range(1, 101);

        


        foreach(Image img in Available_Skill_Image_List)
        {
            foreach(SkillEffect skill_effect in Skill_Effects_List)
            {
                if(img.sprite == skill_effect.Skill_Image)
                {
                    _Skill_Effect = skill_effect;
                    break;
                }
            }
            if(Activate_Skill_Prob <= _Skill_Effect.Skill_Prob && enemy != null)
            {
                DamageWithSkill.ActivateSkill(_Skill_Effect, enemy);
            }

        }


        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();
           
        if(bullet != null)
        {
            bullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
