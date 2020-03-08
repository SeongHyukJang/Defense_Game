using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillRate
{
    public Skill_Rate skill_rate;
    public int weight;


    public enum Skill_Rate
    {
        S,  // 1%
        A,  // 9%
        B,  // 10%
        C,  // 20%
        D,  // 20%
        E,  // 20%
        F   // 20%
    }

    SkillRate(Skill_Rate _skill_rate, int _weight)
    {
        this.skill_rate = _skill_rate;
        this.weight = _weight;
    }


}
