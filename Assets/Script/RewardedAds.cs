using UnityEngine;
using GoogleMobileAds.Api;
using System;


public class RewardedAds : MonoBehaviour
{
    public bool control = false;
    RewardBasedVideoAd rad;
    public String id = "ca-app-pub-2374555340850396/1211398298";


    public void Start()
    {
        rad = RewardBasedVideoAd.Instance;
        rad.OnAdRewarded += Opened;
        rad.OnAdClosed += Close;
        LoadReward();
    }

    public void LoadReward()
    {
        AdRequest request = new AdRequest.Builder().Build();
        rad.LoadAd(request, id);
    }

    void Close(object sender, EventArgs e)
    {
        LoadReward();
    }

    void Opened(object sender, EventArgs e)
    {
        Reward();
    }

    public void Reward()
    {
       control = true;
    }
    public void ShowVideo()
    {
        rad.Show();
    }

}
