using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBannerManager : MonoBehaviour
{
    private void Awake()
    {
        Invoke("ShowBanner", 1f);
    }
    void ShowBanner()
    {
        //AdsManager.Instance.bannerAds._showBanner();
    }
}
