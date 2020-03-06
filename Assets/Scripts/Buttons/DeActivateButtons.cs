using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivateButtons : MonoBehaviour
{
    public GameObject GetSkillButton;
    public GameObject DeleteButton;

    public void DeActivateDeleteButton()
    {
        DeleteButton.SetActive(false);
        GetSkillButton.SetActive(true);
    }
}
