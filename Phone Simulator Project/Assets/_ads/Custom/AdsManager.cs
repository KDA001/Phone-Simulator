using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{
    public InterstitialAd_ interstitialAds;
    public RewardAd_ rewardAds;
    public CoolDownShowAds coolDownShowAds;

    public static AdsManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
            
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        //interstitialAds.LoadInterstitalAd();
    }
}
