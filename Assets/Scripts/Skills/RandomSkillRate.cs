using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSkillRate : MonoBehaviour
{
    public static List<SkillRate> Skill_Rate_Prob = new List<SkillRate>();
    public List<SkillRate> _Skill_Rate_Prob = new List<SkillRate>();
    public static int total = 0;

    void Start()
    {
        Skill_Rate_Prob = _Skill_Rate_Prob;
        
        for (int i = 0; i < Skill_Rate_Prob.Count; i++)
        {
            total += Skill_Rate_Prob[i].weight;
        }
    }


    public static string Get_Random_Skill_Rate()
    {
        int weight = 0;
        int selectNum = 0;

        selectNum = Mathf.RoundToInt(total * Random.Range(0.0f, 1.0f));

        for (int i = 0; i < Skill_Rate_Prob.Count; i++)
        {
            weight += Skill_Rate_Prob[i].weight;
            if (selectNum <= weight)
            {
                string res = Skill_Rate_Prob[i].skill_rate.ToString();
                return res;
            }
        }
        return null;
    }

}
