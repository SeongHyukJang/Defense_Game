using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour
{
    public static TextFadeIn instance;
    public static Text T;
    public Text t;
    public Animation anim;


    private void Start()
    {
        instance = this;
        T = t;
    }

    public static void FadeIn(int _round)
    {
        T.text = "ROUND " + _round.ToString();
        instance.playanim();
    }

    public void playanim()
    {
        anim.Play();
    }


}
