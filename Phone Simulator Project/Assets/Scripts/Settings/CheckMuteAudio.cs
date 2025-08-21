using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMuteAudio : MonoBehaviour
{
    public AudioSource Audios;
    void Start()
    {
        if (PlayerPrefs.GetString("SoundActive") == "ON")
        {
            Audios.mute = false;
        }
        else if (PlayerPrefs.GetString("SoundActive") == "OFF")
        {
            Audios.mute = true;
        }
        else
        {
            PlayerPrefs.SetString("SoundActive", "ON");
            Audios.mute = false;
        }
    }
}
