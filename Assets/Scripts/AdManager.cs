using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour,IUnityAdsListener
{

    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.AddListener(this);
            Advertisement.Initialize("3676905", false);
        }
        while (!Advertisement.IsReady("banner"))
            yield return null;
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show("banner");
    }

    public void LoseAd()
    {

        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }
        GameManager.Instance.tries = Random.Range(2, 4);
    }

    public void OnUnityAdsReady(string placementId)
    {

    }

    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            StoreManager.Instance.AddCoins(30);
        }
        else if (showResult == ShowResult.Failed)
        {

        }
    }

    public void rVideo()
    {
        Advertisement.Show("rewardedVideo");
    }
}
