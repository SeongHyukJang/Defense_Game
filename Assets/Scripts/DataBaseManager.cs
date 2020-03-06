using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseManager : MonoBehaviour
{
    public static List<Skill> skillList_Normal = new List<Skill>();
    public static List<Skill> skillList_Hyper = new List<Skill>();
    public static List<SkillEffect> skillEffects = new List<SkillEffect>();

    void Start()
    {
        skillList_Normal.Clear();
        skillList_Hyper.Clear();
        skillEffects.Clear();

        skillList_Normal.Add(new Skill(1000, "빛", "기본 활입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1001, "불기둥", "기본 불기둥입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1002, "레이저", "기본 레이저입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1003, "독성 식물", "기본 덩쿨입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1004, "점화", "기본 점화입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1005, "중력장", "기본 중력장입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1006, "번개", "기본 번개입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1007, "아이스 볼", "기본 아이스 볼입니다", Skill.Skill_Type.Normal));
        skillList_Normal.Add(new Skill(1008, "치명타", "기본 치명타입니다", Skill.Skill_Type.Normal));

        skillList_Hyper.Add(new Skill(2000, "빛의 심판", "각성 활입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2001, "메테오", "각성 메테오입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2002, "광선빔", "각성 광선빔입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2003, "맹독", "각성 독성 식물입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2004, "화염작렬", "각성 화염작렬입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2005, "중력장 초월", "각성 중력장 초월입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2006, "체인 라이트닝", "각성 체인 라이트닝입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2007, "얼음 초월", "각성 얼음 초월입니다", Skill.Skill_Type.Hyper));
        skillList_Hyper.Add(new Skill(2008, "사형선고", "각성 사형선고입니다", Skill.Skill_Type.Hyper));

        skillEffects.Add(new SkillEffect(1000, 0, 20, 10));
        skillEffects.Add(new SkillEffect(1001, 3, 20, 20));
        skillEffects.Add(new SkillEffect(1002, 0, 20, 30));
        skillEffects.Add(new SkillEffect(1003, 0, 20, 5));
        skillEffects.Add(new SkillEffect(1004, 3, 20, 6));
        skillEffects.Add(new SkillEffect(1005, 3, 20, 16));
        skillEffects.Add(new SkillEffect(1006, 3, 20, 19));
        skillEffects.Add(new SkillEffect(1007, 3, 20, 23));
        skillEffects.Add(new SkillEffect(1008, 3, 20, 50));
    }
}
