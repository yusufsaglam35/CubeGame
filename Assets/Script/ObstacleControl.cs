using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GoogleMobileAds.Api;

public class ObstacleControl : MonoBehaviour
{

    [SerializeField] private GameObject FailedPannel;
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private ParticleSystem prt;
    [SerializeField] private GameObject NextLevelPanel, Rewarded_Button;
    public RewardedAds come_on;
    public PlayerMove Playermove;
    [SerializeField] private byte counter = 0;

    public int spanlevelfinish_cound;

    private int obstacle_count=0;
    public int coutdownTime;
    public Text coutsownDisplay;
    private InterstitialAd interstitial;

  private void RequestInterstitial()
  {
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-2374555340850396/1576739115";
    #else
        string adUnitId = "unexpected_platform";
    #endif

    // Initialize an InterstitialAd.
    this.interstitial = new InterstitialAd(adUnitId);
    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the interstitial with the request.
    this.interstitial.LoadAd(request);
  }
    void Start()
    {
        RequestInterstitial();
       obstacle_count = PlayerPrefs.GetInt("save_obstacle_count");
    }
    void Update()
    {
        if (counter >= 1)
        {
            Rewarded_Button.SetActive(false);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Playermove.speedtouch = 0;
            if (come_on.control == true)
            {
                coutsownDisplay.gameObject.SetActive(true);
                Destroy(collision.gameObject);
                StartCoroutine(CountdownToStart());
            }
            else
            {

            }
        }
    }

    IEnumerator CountdownToStart()
    {

        while (coutdownTime > 0)
        {
            coutsownDisplay.text = coutdownTime.ToString();
            yield return new WaitForSeconds(1f);
            coutdownTime--;
            Playermove.speed = 0;
            FailedPannel.SetActive(false);
        }
        come_on.control = false;
        counter += 1;
        coutsownDisplay.text = "GO !";
        yield return new WaitForSeconds(1f);
        Playermove.speedtouch = 0.009f;
        Playermove.speed = 9;
        coutsownDisplay.gameObject.SetActive(false);

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("obstacle"))
        {
            obstacle_count++;
            PlayerPrefs.SetInt("save_obstacle_count",obstacle_count);
            FailedPannel.SetActive(true);
            Handheld.Vibrate();
            Playermove.speed = 0;

            if (obstacle_count==2)
            {
            if (this.interstitial.IsLoaded())
            {this.interstitial.Show();}
            obstacle_count=0;
            PlayerPrefs.DeleteKey("save_obstacle_count");
            }

           
        }

        if (other.name == "LevelFinish")
        {
            NextLevelPanel.SetActive(true);
            prt.Play();
            Playermove.speed = 0;
        }
      
    }
}
