using UnityEngine;
using GoogleMobileAds.Api;

public class AdsBanner : MonoBehaviour
{
   private BannerView advertisement;
   string Banner_Id = "ca-app-pub-2374555340850396/5025971488";
   public AdPosition Pozition;
  public bool deger = false;
    void Start()
    {
           MobileAds.Initialize(reklamver => {});
           this.BannerReklam();
    }

      void BannerReklam()
    {
        advertisement = new BannerView(Banner_Id,AdSize.GetLandscapeAnchoredAdaptiveBannerAdSizeWithWidth(320),Pozition);
        AdRequest newAdvertisement = new AdRequest.Builder().Build();
         advertisement.LoadAd(newAdvertisement);
    }
     void OnDestroy()
    {
        if( advertisement != null )
          advertisement.Destroy();
    }

}
