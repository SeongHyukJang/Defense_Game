using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
{

    public int Skill_ID;                      // 스킬 고유 아이디
    public string Skill_Name;                 // 스킬 이름
    public string Skill_Description;          // 스킬 설명
    public Sprite Skill_Icon;                 // 스킬 아이콘
    public Skill_Type skill_Type;             // 스킬 타입
    public string skill_Rate;                 // 스킬 등급
    

    public enum Skill_Type
    {
        Normal,
        Hyper
    }
    
    public Skill(int _skill_ID, string _skill_Name, string _skill_Des, Skill_Type _skill_Type)
    {
        this.Skill_ID = _skill_ID;
        this.Skill_Name = _skill_Name;
        this.Skill_Description = _skill_Des;
        this.skill_Type = _skill_Type;
        this.Skill_Icon = Resources.Load("Skills/" + _skill_ID.ToString(), typeof(Sprite)) as Sprite;
    }
}
