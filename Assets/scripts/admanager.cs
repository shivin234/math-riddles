using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class admanager : MonoBehaviour {
            
    private string appID = "ca-app-pub-7783542980250893~8964070046";
    private RewardBasedVideoAd rewardad1;
    private string rewardad1ID = "ca-app-pub-7783542980250893/7667300241";



    private void Start ()
    {
        MobileAds.Initialize(appID);
        this.rewardad1 = RewardBasedVideoAd.Instance;


        rewardad1.OnAdCompleted += Rewardad1_OnAdCompleted;

    }

    private void Rewardad1_OnAdCompleted(object sender, System.EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    public void loadad ()
    {
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardad1.LoadAd(request, rewardad1ID);
        showad();

    }

    public void showad()
    {
        
            rewardad1.Show();
        
    }

}
