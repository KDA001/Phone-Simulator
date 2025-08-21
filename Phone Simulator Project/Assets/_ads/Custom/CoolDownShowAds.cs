using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownShowAds : MonoBehaviour
{
    [SerializeField] float timer = 5f;

    //AdsManager adsManager;
    bool isCanShowAd = false;
    [HideInInspector] public float timeNow;
    float timeStart;

    void Start()
    {
        //adsManager = GetComponent<AdsManager>();
        timeStart = timer;
        timeNow = timer;
    }

    void Update()
    {
        if (timeNow <= 0)
        {
            isCanShowAd = true;
            //timeNow = timeStart;
            //_showAd();
        }
        else
        {
            timeNow -= 1 * Time.deltaTime;
        }
    }
    public void _showAd()
    {
        if (isCanShowAd)
        {
            timeNow = timeStart;
            AdsManager.Instance.interstitialAds.ShowInterstitial();
            //adsManager.interstitialAds.ShowInterstitial();
            print("Show AD");
            isCanShowAd = false;
        }
    }
}
