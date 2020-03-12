﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillEffect
{
    public int Skill_Prob;                  // 스킬 발동확률
    public int Skill_ID;                    // 스킬 아이디
    public float Radius;                    // 스킬 범위
    public float Damage;                      // 스킬 데미지
    public GameObject Skill_Effect;         // 스킬 이펙트
    public Sprite Skill_Image;              // 스킬 이미지
    
    
    private bool canFire;

    public void ExtraSkillEffects(Enemy e, float _damage)         // 추가 스킬 효과
    {
        switch (this.Skill_ID)
        {
            case 1000:
                _damage = e.startHealth * 0.2f;
                e.TakeDamage(_damage);              // 전체체력 퍼뎀
                // 방깍
                break;
            case 1001:
                e.TakeDamage(_damage);
                // 큰 범위
                break;
            case 1002:
                //StartCoroutine(DotDamage());
                // 슬로우
                // 도트뎀
                // StartCoroutine??
                break;
            case 1003:
                // 도트뎀
                break;
            case 1004:
                // joint component?
                // 홀딩(끌어당김)
                break;
            case 1005:
                // 스턴 (3마리)
                break;
            case 1006:
                // 적 띄우기 + 데미지(총 3번)
                break;
            case 1007:
                // 포탄에 추가적인 이펙트
                // 추가뎀
                // 100퍼 확률
                break;
            default:
                break;
        }
    }
    public SkillEffect(int _skill_ID, float _Radius, float _Damage, int _Skill_Prob)
    {
        this.Skill_ID = _skill_ID;
        this.Radius = _Radius;
        this.Damage = _Damage;
        this.Skill_Prob = _Skill_Prob;
        this.Skill_Image = Resources.Load("Skills/" + _skill_ID.ToString(), typeof(Sprite)) as Sprite;
        this.Skill_Effect = Resources.Load("Skill Effects/" + _skill_ID,typeof(GameObject)) as GameObject;
        //this.Skill_Effect = Resources.Load("Skill Effects/1001", typeof(GameObject)) as GameObject;

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.Skill_Effect.transform.position, this.Radius);
    }

    //IEnumerator DotDamage()
    //{
    //    while(true)
    //    {
    //        Debug.Log("데미지");
    //        yield return new WaitForSeconds(1f);
            
    //    }
    //}

}
