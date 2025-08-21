using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI ResolutionText;
    public TMP_Dropdown GraphicsDropDown;
    public void Awake()
    {
        Application.targetFrameRate = 300;
        if (PlayerPrefs.HasKey("Quality_index"))
        {
            GraphicsDropDown.value = PlayerPrefs.GetInt("Quality_index");
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality_index"));
        }

        if (!PlayerPrefs.HasKey("Device_Real_Resolution_width") && !PlayerPrefs.HasKey("Device_Real_Resolution_height"))
        {
            PlayerPrefs.SetFloat("Device_Real_Resolution_width", Screen.currentResolution.width);
            PlayerPrefs.SetFloat("Device_Real_Resolution_height", Screen.currentResolution.height);
        }

        if(PlayerPrefs.HasKey("Device_Save_Resolution_width") && PlayerPrefs.HasKey("Device_Save_Resolution_height"))
        {
            Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetFloat("Device_Save_Resolution_width")), Mathf.RoundToInt(PlayerPrefs.GetFloat("Device_Save_Resolution_height")), FullScreenMode.ExclusiveFullScreen, 300);
        }

        //if(!PlayerPrefs.HasKey("Device_Save_Resolution_width") && !PlayerPrefs.HasKey("Device_Save_Resolution_height"))
        //{
        //    PlayerPrefs.SetFloat("Device_Save_Resolution_width", Screen.currentResolution.width / 1.25f);
        //    PlayerPrefs.SetFloat("Device_Save_Resolution_height", Screen.currentResolution.height / 1.25f);

        //    Screen.SetResolution(Mathf.RoundToInt(Screen.currentResolution.width / 1.25f), Mathf.RoundToInt(Screen.currentResolution.height / 1.25f), FullScreenMode.ExclusiveFullScreen, 300);


        //}
        //else if(PlayerPrefs.HasKey("Device_Save_Resolution_width") && PlayerPrefs.HasKey("Device_Save_Resolution_height"))
        //{
        //    Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetFloat("Device_Save_Resolution_width")), Mathf.RoundToInt(PlayerPrefs.GetFloat("Device_Save_Resolution_height")), FullScreenMode.ExclusiveFullScreen, 300);
        //}
        print("Setting Load");

    }
    private void FixedUpdate()
    {
        ResolutionText.text = Screen.currentResolution.width + "x" + Screen.currentResolution.height;
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("Quality_index", QualitySettings.GetQualityLevel());
    }

    public void ResolutionPlus()
    {
        if(Screen.currentResolution.width < PlayerPrefs.GetFloat("Device_Real_Resolution_width"))
        {
            Screen.SetResolution(Mathf.RoundToInt(Screen.currentResolution.width * 1.25f), Mathf.RoundToInt(Screen.currentResolution.height * 1.25f), FullScreenMode.ExclusiveFullScreen, 300);
            InvokeRepeating("SaveSetting", 1, 0);
        }
    }
    public void ResolutionMinus()
    {
        if (Screen.currentResolution.width > PlayerPrefs.GetFloat("Device_Real_Resolution_width")/2)
        {
            Screen.SetResolution(Mathf.RoundToInt(Screen.currentResolution.width / 1.25f), Mathf.RoundToInt(Screen.currentResolution.height / 1.25f), FullScreenMode.ExclusiveFullScreen, 300);
            InvokeRepeating("SaveSetting", 1, 0);
        }
    }
    public void DefaultSetting()
    {
        GraphicsDropDown.value = 2;
        PlayerPrefs.SetInt("Quality_index", QualitySettings.GetQualityLevel());
        Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetFloat("Device_Real_Resolution_width")), Mathf.RoundToInt(PlayerPrefs.GetFloat("Device_Real_Resolution_height")), FullScreenMode.ExclusiveFullScreen, 300);
    }

    public void SaveSetting()
    {
        PlayerPrefs.SetFloat("Device_Save_Resolution_width", Screen.currentResolution.width);
        PlayerPrefs.SetFloat("Device_Save_Resolution_height", Screen.currentResolution.height);
    }
}
