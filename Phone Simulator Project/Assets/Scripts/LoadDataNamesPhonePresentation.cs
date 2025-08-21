using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadDataNamesPhonePresentation : MonoBehaviour
{
    public TextMeshProUGUI textNamePhone;
    public TextMeshProUGUI textNameCompany;
    void Awake()
    {
        if (PlayerPrefs.HasKey("Save_Name_Phone"))
        {
            textNamePhone.text = PlayerPrefs.GetString("Save_Name_Phone");
        }

        if (PlayerPrefs.HasKey("Save_Name_Company"))
        {
            textNameCompany.text = PlayerPrefs.GetString("Save_Name_Company");
        }
    }
}
