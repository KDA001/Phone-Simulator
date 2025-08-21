using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraHelper : MonoBehaviour
{
    public GameObject[] FrontalCamers;
    public TextMeshProUGUI activeFrontalText;
    public int indexActiveFrontal;


    public GameObject[] MainCamers;
    public TextMeshProUGUI activeMainText;
    public int indexActiveMain;

    private void Start()
    {
        for(int i = 0; i < FrontalCamers.Length; i++)
        {
            if(FrontalCamers[i].active == true)
            {
                indexActiveFrontal = i;
                activeFrontalText.text = (indexActiveFrontal + 1).ToString();
            }
        }


        for (int i = 0; i < MainCamers.Length; i++)
        {
            if (MainCamers[i].active == true)
            {
                indexActiveMain = i;
                activeMainText.text = (indexActiveMain + 1).ToString();
            }
        }
    }

    public void Left_frontal_Camera()
    {
        if (indexActiveFrontal > 0)
        {
            indexActiveFrontal--;
            activeFrontalText.text = (indexActiveFrontal + 1).ToString();

            for (int i = 0; i < FrontalCamers.Length; i++)
            {
                FrontalCamers[i].active = false;
                FrontalCamers[indexActiveFrontal].active = true;
            }
        }
    }
    public void Right_frontal_Camera()
    {
        if (indexActiveFrontal < FrontalCamers.Length - 1)
        {
            indexActiveFrontal++;
            activeFrontalText.text = (indexActiveFrontal + 1).ToString();

            for (int i = 0; i < FrontalCamers.Length; i++)
            {
                FrontalCamers[i].active = false;
                FrontalCamers[indexActiveFrontal].active = true;
            }
        }
    }

    public void Left_main_Camera()
    {
        if (indexActiveMain > 0)
        {
            indexActiveMain--;
            activeMainText.text = (indexActiveMain + 1).ToString();

            for (int i = 0; i < MainCamers.Length; i++)
            {
                MainCamers[i].active = false;
                MainCamers[indexActiveMain].active = true;
            }
        }
    }

    public void Right_main_Camera()
    {
        if (indexActiveMain < MainCamers.Length - 1)
        {
            indexActiveMain++;
            activeMainText.text = (indexActiveMain + 1).ToString();

            for (int i = 0; i < MainCamers.Length; i++)
            {
                MainCamers[i].active = false;
                MainCamers[indexActiveMain].active = true;
            }
        }
    }
}
