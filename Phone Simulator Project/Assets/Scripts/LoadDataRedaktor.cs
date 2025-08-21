using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadDataRedaktor : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Display;

    public Material _materialPhone;
    public Material _materialCamera;

    public Material _materialOS;

    public GameObject[] FrontCamers;
    public GameObject[] BackCamers;

    public TextMeshProUGUI MarkingText;

    [Header("UI Redaktor")]
    public Slider _sliderScalePhone;
    public Slider _sliderWidthPhone;
    public Slider _sliderScaleDisplay;
    public Slider _sliderMarkingTransparency;
    public Slider _sliderMarkingBrightness;

    public CameraHelper _cameraHelper;

    public TMP_Dropdown _dropDownMarkingCountry;

    public TMP_InputField CompanyText;
    public TMP_InputField NamePhoneText;

    public Button[] OS_Buttons;
    public Texture[] _texturOS;

    public TMP_Dropdown _dropDownRAM;
    public TMP_Dropdown _dropDownROM;

    public TMP_Dropdown _dropDownNetwork;

    public TMP_Dropdown _dropDownBattery;



    [Header("defaut charakteristik")]
    public Vector3 defuatScalePhone;
    public Vector3 defuatScaleDisplay;

    public Color defuatColorPhone;
    public Color defuatColorCamera;

    public Color defuatColorMarkingText;
    public string defuatStringMarkingCountry;

    [Range(0, 3)]
    public int defuatIndexFrontCamera;
    [Range(0, 6)]
    public int defuatIndexMainCamera;

    [Range(0, 3)]
    public int defuatIndexOS;

    [Range(0, 5)]
    public int defuatIndexRAM;
    [Range(0, 4)]
    public int defuatIndexROM;

    [Range(0, 2)]
    public int defuatIndexNetwork;

    [Range(0, 3)]
    public int defuatIndexBattery;
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

            // UI
            _sliderScalePhone.value = PlayerPrefs.GetFloat("Save_Size_Y_Phone");
            _sliderWidthPhone.value = PlayerPrefs.GetFloat("Save_Size_X_Phone");
        }
        else
        {
            Phone.transform.localScale = defuatScalePhone;

            // UI
            _sliderScalePhone.value = defuatScalePhone.x;
            _sliderWidthPhone.value = defuatScalePhone.x;
        }



        // Передача сохраненных данных размера Дисплея
        if (PlayerPrefs.HasKey("Save_Size_X_Display_Phone"))
        {
            Display.transform.localScale = new Vector3(PlayerPrefs.GetFloat("Save_Size_X_Display_Phone"), PlayerPrefs.GetFloat("Save_Size_Y_Display_Phone"), PlayerPrefs.GetFloat("Save_Size_Z_Display_Phone"));

            _sliderScaleDisplay.value = PlayerPrefs.GetFloat("Save_Size_X_Display_Phone");
        }
        else
        {
            Display.transform.localScale = defuatScaleDisplay;

            // UI
            _sliderScaleDisplay.value = defuatScaleDisplay.x;
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

            // UI
            _cameraHelper.indexActiveFrontal = PlayerPrefs.GetInt("Save_Selected_Value_Front_Camera");
            _cameraHelper.activeFrontalText.text = (PlayerPrefs.GetInt("Save_Selected_Value_Front_Camera") + 1).ToString();
        }
        else
        {
            for (int i = 0; i < FrontCamers.Length; i++)
            {
                FrontCamers[i].active = false;
            }
            FrontCamers[defuatIndexFrontCamera].active = true;

            // UI
            _cameraHelper.indexActiveFrontal = defuatIndexFrontCamera;
            _cameraHelper.activeFrontalText.text = (defuatIndexFrontCamera + 1).ToString();
        }


        // Передача сохраненных данных выбранной задней камеры
        if (PlayerPrefs.HasKey("Save_Selected_Value_Back_Camera"))
        {
            for (int i = 0; i < BackCamers.Length; i++)
            {
                BackCamers[i].active = false;
            }
            BackCamers[PlayerPrefs.GetInt("Save_Selected_Value_Back_Camera")].active = true;

            // UI
            _cameraHelper.indexActiveMain = PlayerPrefs.GetInt("Save_Selected_Value_Back_Camera");
            _cameraHelper.activeMainText.text = (PlayerPrefs.GetInt("Save_Selected_Value_Back_Camera") + 1).ToString();
        }
        else
        {
            for (int i = 0; i < BackCamers.Length; i++)
            {
                BackCamers[i].active = false;
            }
            BackCamers[defuatIndexMainCamera].active = true;

            // UI
            _cameraHelper.indexActiveMain = defuatIndexMainCamera;
            _cameraHelper.activeMainText.text = (defuatIndexMainCamera + 1).ToString();
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

        // Передача сохраненных данных индекса в dropDown производителя
        if (PlayerPrefs.HasKey("Save_Value_Marking_DropDown"))
        {
            // UI
            _dropDownMarkingCountry.value = PlayerPrefs.GetInt("Save_Value_Marking_DropDown");
        }
        else
        {
            _dropDownMarkingCountry.value = 0;
        }


        // Передача сохраненных данных яркости текста производителя
        if (PlayerPrefs.HasKey("Save_Color_R_Marking_text"))
        {
            MarkingText.color = new Color(PlayerPrefs.GetFloat("Save_Color_R_Marking_text"), PlayerPrefs.GetFloat("Save_Color_G_Marking_text"), PlayerPrefs.GetFloat("Save_Color_B_Marking_text"), PlayerPrefs.GetFloat("Save_Color_A_Marking_text"));

            // UI
            _sliderMarkingBrightness.value = PlayerPrefs.GetFloat("Save_Color_R_Marking_text");
            _sliderMarkingTransparency.value = PlayerPrefs.GetFloat("Save_Color_A_Marking_text");
        }
        else
        {
            MarkingText.color = defuatColorMarkingText;

            //UI
            _sliderMarkingBrightness.value = defuatColorMarkingText.r;
            _sliderMarkingTransparency.value = defuatColorMarkingText.a;
        }

        // Передача сохраненных данных имени компании
        if (PlayerPrefs.HasKey("Save_Name_Company"))
        {
            CompanyText.text = PlayerPrefs.GetString("Save_Name_Company");
        }

        // Передача сохраненных данных Имени телефона
        if (PlayerPrefs.HasKey("Save_Name_Phone"))
        {
            NamePhoneText.text = PlayerPrefs.GetString("Save_Name_Phone");
        }


        // Передача сохраненных данных выбранного ОС
        if (PlayerPrefs.HasKey("Save_Selected_Value_OS"))
        {
            for(int i = 0; i < OS_Buttons.Length; i ++)
            {
                OS_Buttons[i].interactable = true;
            }
            OS_Buttons[PlayerPrefs.GetInt("Save_Selected_Value_OS")].interactable = false;

            // UI
            _materialOS.mainTexture = _texturOS[PlayerPrefs.GetInt("Save_Selected_Value_OS")];
            _materialOS.SetTexture("_EmissionMap", _texturOS[PlayerPrefs.GetInt("Save_Selected_Value_OS")]);
        }
        else
        {
            OS_Buttons[defuatIndexOS].interactable = false;

            // UI
            _materialOS.mainTexture = _texturOS[defuatIndexOS];
            _materialOS.SetTexture("_EmissionMap", _texturOS[defuatIndexOS]);
        }

        // Передача сохраненных данных выбранного RAM
        if (PlayerPrefs.HasKey("Save_value_RAM"))
        {
            _dropDownRAM.value = PlayerPrefs.GetInt("Save_value_RAM");
        }
        else
        {
            _dropDownRAM.value = defuatIndexRAM;
        }

        // Передача сохраненных данных выбранного ROM
        if (PlayerPrefs.HasKey("Save_value_ROM"))
        {
            _dropDownROM.value = PlayerPrefs.GetInt("Save_value_ROM");
        }
        else
        {
            _dropDownROM.value = defuatIndexROM;
        }


        // Передача сохраненных данных выбранной сети
        if (PlayerPrefs.HasKey("Save_value_Net"))
        {
            _dropDownNetwork.value = PlayerPrefs.GetInt("Save_value_Net");
        }
        else
        {
            _dropDownNetwork.value = defuatIndexNetwork;
        }

        // Передача сохраненных данных выбранной Батареи
        if (PlayerPrefs.HasKey("Save_value_Battery"))
        {
            _dropDownBattery.value = PlayerPrefs.GetInt("Save_value_Battery");
        }
        else
        {
            _dropDownBattery.value = defuatIndexBattery;
        }
    }
}
