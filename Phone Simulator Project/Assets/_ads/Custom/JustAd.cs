using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustAd : MonoBehaviour
{
    void Start()
    {
        AdsManager.Instance.coolDownShowAds._showAd();
    }
}
