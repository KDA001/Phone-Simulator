using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CheckTicTokAudio : MonoBehaviour
{
    private VideoPlayer _videoPlayer;
    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();

        if (PlayerPrefs.GetString("SoundActive") == "ON")
        {
            _videoPlayer.SetDirectAudioMute(0, false);
        }
        else if (PlayerPrefs.GetString("SoundActive") == "OFF")
        {
            _videoPlayer.SetDirectAudioMute(0, true);
        }
        else
        {
            PlayerPrefs.SetString("SoundActive", "ON");
            _videoPlayer.SetDirectAudioMute(0, false);
        }
    }
}
