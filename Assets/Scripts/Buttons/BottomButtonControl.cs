using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class BottomButtonControl : MonoBehaviour
{
    private List<Skill> Skill_List_Normal = DataBaseManager.skillList_Normal;
    private List<Skill> Skill_List_Hyper = DataBaseManager.skillList_Hyper;
    private List<Skill> Deleted_Skill_List = new List<Skill>();

    private Skill Selected_Skill;
    Image _Selected_Skill_Image;

    int _Selected_Checker;
    private List<bool> checker = new List<bool>() { false, false, false, false };

    public static List<Image> Current_Images; 
    private List<Image> imgs;
    public Image img_1;
    public Image img_2;
    public Image img_3;
    public Image img_4;

    public GameObject delete_button;
    public GameObject Get_Skill_button;

    public Text skill_des;

    private string _skill_rate;
    private int currentMoney;
    private int Skill_Index;

    private void Start()
    {
        imgs = new List<Image>() { img_1, img_2, img_3, img_4 };
        Current_Images = imgs;
    }

    public void Get_Skill()
    {
        currentMoney = PlayerStats.Money;
        if (currentMoney >= 1500)
        {
            Skill_Index = Random.Range(0, Skill_List_Normal.Count);
            Selected_Skill = Skill_List_Normal[Skill_Index];

            Random_Skill_Image(Selected_Skill);
            PlayerStats.Money -= 1500;
        }
        else
        {
            Debug.Log("Not enough Money");
        }
    }
    private void Random_Skill_Image(Skill _skill)
    {

        for (int i = 0; i < 4; i++)
        {
            if (checker[i] == false)
            {
                checker[i] = true;

                imgs[i].sprite = _skill.Skill_Icon;
                _skill.skill_Rate = RandomSkillRate.Get_Random_Skill_Rate();
                Tower.Available_Skill_Image_List.Add(imgs[i]);
                
                Deleted_Skill_List.Add(_skill);
                Skill_List_Normal.Remove(_skill);

                break;
            }
        }
    }

    public void Delete_Skill()
    {
        Deleted_Skill_List.Remove(Selected_Skill);
        Skill_List_Normal.Add(Selected_Skill);

        skill_des.text = null;

        foreach (Image _img in Tower.Available_Skill_Image_List)
        {
            if (_img.sprite == _Selected_Skill_Image.sprite)
            {
                Tower.Available_Skill_Image_List.Remove(_img);
                break;
            }
        }

        _Selected_Skill_Image.sprite = Resources.Load("Default Image/circle_3", typeof(Sprite)) as Sprite;
        checker[_Selected_Checker] = false;
        Get_Skill_button.SetActive(true);
        delete_button.SetActive(false);
        
        PlayerStats.Money += 1000;
    }
    public void Activate_Delete_Button_1()
    {
        foreach (Skill _skill in Deleted_Skill_List)
        {
            if (_skill.Skill_Icon == img_1.sprite)
            {
                Selected_Skill = _skill;
                break;
            }
        }
        Random_Skill_Des();

        Get_Skill_button.SetActive(false);
        delete_button.SetActive(true);

        _Selected_Skill_Image = img_1;
        _Selected_Checker = 0;
    }

    public void Activate_Delete_Button_2()
    {
        foreach (Skill _skill in Deleted_Skill_List)
        {
            if (_skill.Skill_Icon == img_2.sprite)
            {
                Selected_Skill = _skill;
                break;
            }
        }
        Random_Skill_Des();

        Get_Skill_button.SetActive(false);
        delete_button.SetActive(true);

        _Selected_Skill_Image = img_2;
        _Selected_Checker = 1;
    }

    public void Activate_Delete_Button_3()
    {
        foreach (Skill _skill in Deleted_Skill_List)
        {
            if (_skill.Skill_Icon == img_3.sprite)
            {
                Selected_Skill = _skill;
                break;
            }
        }
        Random_Skill_Des();

        Get_Skill_button.SetActive(false);
        delete_button.SetActive(true);
        

        _Selected_Skill_Image = img_3;
        _Selected_Checker = 2;
    }

    public void Activate_Delete_Button_4()
    {
        foreach (Skill _skill in Deleted_Skill_List)
        {
            if (_skill.Skill_Icon == img_4.sprite)
            {
                Selected_Skill = _skill;
                break;
            }
        }
        Random_Skill_Des();

        Get_Skill_button.SetActive(false);
        delete_button.SetActive(true);

        _Selected_Skill_Image = img_4;
        _Selected_Checker = 3;
    }
    public void Random_Skill_Des()
    {
        skill_des.text = Selected_Skill.skill_Rate + "등급 " + Selected_Skill.Skill_Description;
    }
}
