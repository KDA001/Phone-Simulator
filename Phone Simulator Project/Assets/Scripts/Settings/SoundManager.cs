using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource Audios;
    public Toggle _toggle;
    public void Awake()
    {
        if(PlayerPrefs.GetString("SoundActive") == "ON")
        {
            _toggle.isOn = true;
            Audios.mute = false;
        }
        else if(PlayerPrefs.GetString("SoundActive") == "OFF")
        {
            _toggle.isOn = false;
            Audios.mute = true;
        }
        if(PlayerPrefs.HasKey("SoundActive") == false)
        {
            PlayerPrefs.SetString("SoundActive", "ON");
            Audios.mute = false;
        }
    }

    public void Sound_bool(bool isOn)
    {
        if(isOn)
        {
            PlayerPrefs.SetString("SoundActive", "ON");

            Audios.mute = false;
        }
        else if(!isOn)
        {
            PlayerPrefs.SetString("SoundActive", "OFF");

            Audios.mute = true;
        }
    }
}
