using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveDataPhone : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Display;

    public Material _materialPhone;
    public Material _materialCamera;
    public GameObject[] FrontCamers;
    public GameObject[] BackCamers;

    public TMP_InputField CompanyText;
    public TMP_InputField NamePhoneText;
    public TextMeshProUGUI MarkingText;
    public TMP_Dropdown _dropDownMarkingText;

    public Button[] OS_Buttons;
    public TMP_Dropdown _dropDownRAM;
    public TMP_Dropdown _dropDownROM;
    public TMP_Dropdown _dropDownNetwork;
    public TMP_Dropdown _dropDownBattery;

    public void _save()
    {
        // Сохранения размера смартфона
        PlayerPrefs.SetFloat("Save_Size_X_Phone", Phone.transform.localScale.x);
        PlayerPrefs.SetFloat("Save_Size_Y_Phone", Phone.transform.localScale.y);
        PlayerPrefs.SetFloat("Save_Size_Z_Phone", Phone.transform.localScale.z);

        // Сохранения размера Дисплея
        PlayerPrefs.SetFloat("Save_Size_X_Display_Phone", Display.transform.localScale.x);
        PlayerPrefs.SetFloat("Save_Size_Y_Display_Phone", Display.transform.localScale.y);
        PlayerPrefs.SetFloat("Save_Size_Z_Display_Phone", Display.transform.localScale.z);

        // Сохранения цвета Корпуса
        PlayerPrefs.SetFloat("Save_Color_R_PhoneMaterial", _materialPhone.color.r);
        PlayerPrefs.SetFloat("Save_Color_G_PhoneMaterial", _materialPhone.color.g);
        PlayerPrefs.SetFloat("Save_Color_B_PhoneMaterial", _materialPhone.color.b);
        PlayerPrefs.SetFloat("Save_Color_A_PhoneMaterial", _materialPhone.color.a);

        // Сохранения цвета Камеры
        PlayerPrefs.SetFloat("Save_Color_R_CameraMaterial", _materialCamera.color.r);
        PlayerPrefs.SetFloat("Save_Color_G_CameraMaterial", _materialCamera.color.g);
        PlayerPrefs.SetFloat("Save_Color_B_CameraMaterial", _materialCamera.color.b);
        PlayerPrefs.SetFloat("Save_Color_A_CameraMaterial", _materialCamera.color.a);

        // Сохранения выбранной фронтальной камеры
        for (int i = 0; i < FrontCamers.Length; i++)
        {
            if (FrontCamers[i].active == true)
            {
                PlayerPrefs.SetInt("Save_Selected_Value_Front_Camera", i);
            }
        }

        // Сохранения выбранной задней камеры
        for (int i = 0; i < BackCamers.Length; i++)
        {
            if (BackCamers[i].active == true)
            {
                PlayerPrefs.SetInt("Save_Selected_Value_Back_Camera", i);
            }
        }


        // Сохранения яркости текста производителя (made_in)
        PlayerPrefs.SetFloat("Save_Color_R_Marking_text", MarkingText.color.r);
        PlayerPrefs.SetFloat("Save_Color_G_Marking_text", MarkingText.color.g);
        PlayerPrefs.SetFloat("Save_Color_B_Marking_text", MarkingText.color.b);
        PlayerPrefs.SetFloat("Save_Color_A_Marking_text", MarkingText.color.a);

        // Сохранения текста производителя (made_in)
        PlayerPrefs.SetString("Save_text_Marking_text", MarkingText.text);

        // Сохранения индекса в dropDown производителя для Редактора (made_in)
        PlayerPrefs.SetInt("Save_Value_Marking_DropDown", _dropDownMarkingText.value);


        // Сохранение Имени компании
        PlayerPrefs.SetString("Save_Name_Company", CompanyText.text);

        // Сохранение Имени телефона
        PlayerPrefs.SetString("Save_Name_Phone", NamePhoneText.text);


        // Сохранения выбранного ОС
        for (int i = 0; i < OS_Buttons.Length; i++)
        {
            if (OS_Buttons[i].interactable == false)
            {
                PlayerPrefs.SetInt("Save_Selected_Value_OS", i);
            }
        }

        // Сохранение кол во ОЗУ
        PlayerPrefs.SetString("Save_RAM", _dropDownRAM.captionText.text);
        PlayerPrefs.SetInt("Save_value_RAM", _dropDownRAM.value);

        // Сохранение кол во ПЗУ
        PlayerPrefs.SetString("Save_ROM", _dropDownROM.captionText.text);
        PlayerPrefs.SetInt("Save_value_ROM", _dropDownROM.value);

        // Сохранение Сети
        PlayerPrefs.SetString("Save_Net", _dropDownNetwork.captionText.text);
        PlayerPrefs.SetInt("Save_value_Net", _dropDownNetwork.value);

        // Сохранение Батареи
        PlayerPrefs.SetString("Save_Battery", _dropDownBattery.captionText.text);
        PlayerPrefs.SetInt("Save_value_Battery", _dropDownBattery.value);
    }
}
