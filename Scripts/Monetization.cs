using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Monetization : MonoBehaviour, IUnityAdsListener
{
    private Player _player;

    string gameId = "3547735";
    bool testMode = false;

    string myPlacementId = "rewardedVideo";



    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        Advertisement.Initialize(gameId, testMode);
        Advertisement.AddListener(this);
    }
    public void DisplayVideoAd()
    {
        Advertisement.Show(myPlacementId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
            _player.ContinueWithAd();
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
            _player.ContinueWithAd();
        }
        else if (showResult == ShowResult.Failed)
        {
            _player.ContinueWithAd();
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
    
}
