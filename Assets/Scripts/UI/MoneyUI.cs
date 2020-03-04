using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public Text MoneyCountText;
    void Update()
    {
        MoneyCountText.text = PlayerStats.Money.ToString();
    }


}
