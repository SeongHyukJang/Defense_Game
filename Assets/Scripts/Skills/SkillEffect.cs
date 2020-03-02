using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillEffect
{
    public int Skill_Prob;                  // 스킬 발동확률
    public int Skill_ID;                    // 스킬 아이디
    public float Radius;                    // 스킬 범위
    public float Damage;                    // 스킬 데미지
    public GameObject Skill_Effect;         // 스킬 이펙트
    public Sprite Skill_Image;              // 스킬 이미지


    public SkillEffect(int _skill_ID, float _Radius, float _Damage, int _Skill_Prob)
    {
        this.Skill_ID = _skill_ID;
        this.Radius = _Radius;
        this.Damage = _Damage;
        this.Skill_Prob = _Skill_Prob;
        this.Skill_Image = Resources.Load("Skills/" + _skill_ID.ToString(), typeof(Sprite)) as Sprite;
        this.Skill_Effect = Resources.Load("Skill Effects/" + _skill_ID,typeof(GameObject)) as GameObject;
    }

    public void ShowEffect()
    {
        Debug.Log(this.Skill_ID);
    }
}
