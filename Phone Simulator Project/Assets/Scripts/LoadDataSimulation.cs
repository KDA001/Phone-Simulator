using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadDataSimulation : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Display;

    public Material _materialPhone;
    public Material _materialCamera;



    public GameObject[] FrontCamers;
    public GameObject[] BackCamers;

    public TextMeshProUGUI MarkingText;

    [Header("OS")]
    public Material DisplayON;
    public Texture _textureFonAndroid;
    public Texture _textureFonIOS;

    [Header("defaut charakteristik")]
    public Vector3 defuatScalePhone;
    public Vector3 defuatScaleDisplay;

    public Color defuatColorPhone;
    public Color defuatColorCamera;

    [Range(0, 3)]
    public int defuatIndexFrontCamera;
    [Range(0, 6)]
    public int defuatIndexMainCamera;

    public string defuatStringMarkingCountry;
    public Color defuatColorMarkingText;

    private void Start()
    {
        _load();
    }
    public void _load()
    {
        // Передача сохраненных данных размера смартфона
        if (PlayerPrefs.HasKey("Save_Size_X_Phone"))
        {
            Phone.transform.localScale = new Vector3(PlayerPrefs.GetFloat("Save_Size_X_Phone"), PlayerPrefs.GetFloat("Save_Size_Y_Phone"), PlayerPrefs.GetFloat("Save_Size_Z_Phone"));
        }
        else
        {
            Phone.transform.localScale = defuatScalePhone;
        }

        // Передача сохраненных данных размера Дисплея
        if (PlayerPrefs.HasKey("Save_Size_X_Display_Phone"))
        {
            Display.transform.localScale = new Vector3(PlayerPrefs.GetFloat("Save_Size_X_Display_Phone"), PlayerPrefs.GetFloat("Save_Size_Y_Display_Phone"), PlayerPrefs.GetFloat("Save_Size_Z_Display_Phone"));
        }
        else
        {
            Display.transform.localScale = defuatScaleDisplay;
        }

        // Передача сохраненных данных цвета корпуса
        if (PlayerPrefs.HasKey("Save_Color_R_PhoneMaterial"))
        {
            _materialPhone.color = new Color(PlayerPrefs.GetFloat("Save_Color_R_PhoneMaterial"), PlayerPrefs.GetFloat("Save_Color_G_PhoneMaterial"), PlayerPrefs.GetFloat("Save_Color_B_PhoneMaterial"), PlayerPrefs.GetFloat("Save_Color_A_PhoneMaterial"));
        }
        else
        {
            _materialPhone.color = defuatColorPhone;
        }

        // Передача сохраненных данных цвета Камеры
        if (PlayerPrefs.HasKey("Save_Color_R_CameraMaterial"))
        {
            _materialCamera.color = new Color(PlayerPrefs.GetFloat("Save_Color_R_CameraMaterial"), PlayerPrefs.GetFloat("Save_Color_G_CameraMaterial"), PlayerPrefs.GetFloat("Save_Color_B_CameraMaterial"), PlayerPrefs.GetFloat("Save_Color_A_CameraMaterial"));
        }
        else
        {
            _materialCamera.color = defuatColorCamera;
        }

        // Передача сохраненных данных выбранной фронтальной камеры
        if (PlayerPrefs.HasKey("Save_Selected_Value_Front_Camera"))
        {
            for (int i = 0; i < FrontCamers.Length; i++)
            {
                FrontCamers[i].active = false;
            }
            FrontCamers[PlayerPrefs.GetInt("Save_Selected_Value_Front_Camera")].active = true;
        }
        else
        {
            for (int i = 0; i < FrontCamers.Length; i++)
            {
                FrontCamers[i].active = false;
            }
            FrontCamers[defuatIndexFrontCamera].active = true;
        }

        // Передача сохраненных данных выбранной задней камеры
        if (PlayerPrefs.HasKey("Save_Selected_Value_Back_Camera"))
        {
            for (int i = 0; i < BackCamers.Length; i++)
            {
                BackCamers[i].active = false;
            }
            BackCamers[PlayerPrefs.GetInt("Save_Selected_Value_Back_Camera")].active = true;
        }
        else
        {
            for (int i = 0; i < BackCamers.Length; i++)
            {
                BackCamers[i].active = false;
            }
            BackCamers[defuatIndexMainCamera].active = true;
        }

        // Передача сохраненных данных выбранной ОС
        if (PlayerPrefs.HasKey("Save_Selected_Value_OS"))
        {
            if(PlayerPrefs.GetInt("Save_Selected_Value_OS") == 0)
            {
                DisplayON.SetTexture("_EmissionMap", _textureFonAndroid);
                DisplayON.mainTexture = _textureFonAndroid;
            }
            else if (PlayerPrefs.GetInt("Save_Selected_Value_OS") == 1)
            {
                DisplayON.SetTexture("_EmissionMap", _textureFonIOS);
                DisplayON.mainTexture = _textureFonIOS;
            }
        }
        else
        {
            DisplayON.SetTexture("_EmissionMap", _textureFonAndroid);
            DisplayON.mainTexture = _textureFonAndroid;
        }

        // Передача сохраненных данных текста производителя
        if (PlayerPrefs.HasKey("Save_text_Marking_text"))
        {
            MarkingText.text = PlayerPrefs.GetString("Save_text_Marking_text");
        }
        else
        {
            MarkingText.text = "Model: RT3749" + "\n" + "Made in " + defuatStringMarkingCountry;
        }

        // Передача сохраненных данных яркости текста производителя
        if (PlayerPrefs.HasKey("Save_Color_R_Marking_text"))
        {
            MarkingText.color = new Color(PlayerPrefs.GetFloat("Save_Color_R_Marking_text"), PlayerPrefs.GetFloat("Save_Color_G_Marking_text"), PlayerPrefs.GetFloat("Save_Color_B_Marking_text"), PlayerPrefs.GetFloat("Save_Color_A_Marking_text"));
        }
        else
        {
            MarkingText.color = defuatColorMarkingText;
        }
    }
}
