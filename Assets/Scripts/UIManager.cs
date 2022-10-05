using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SgLib;

public class UIManager : MonoBehaviour
{


    [Header("Object References")]
    public GameManager gameManager;
    public GameObject header;
    public Text title;
    public Text score;
    public Text bestScore;
    public Text coins;
    public Text coinsStore;
    public Image diamond;
    public GameObject tapToStart;
    public AudioScript audioScript;
    public GameObject menuButtons;
    public GameObject menuButtonsOver;
    public GameObject soundBtn;
    public GameObject storeButton;
    public GameObject store;
    public GameObject randomBuy;
    public GameObject video;
    public GameObject backToMenu;
    public ScoreManager scoreManager;
    [Header("Premium Features Buttons")]
    public GameObject leaderboardBtn;
    public GameObject removeAdsBtn;
    

    private bool isMuted = true;
 

    void OnEnable()
    {
        GameManager.GameStateChanged += GameManager_GameStateChanged;
        ScoreManager.ScoreUpdated += OnScoreUpdated;
    }

    void OnDisable()
    {
         GameManager.GameStateChanged -= GameManager_GameStateChanged;
        ScoreManager.ScoreUpdated -= OnScoreUpdated;
    }

    // Use this for initialization
    void Start()
    {
        ShowStartUI();
       
       
      
    }

  
   
    // Update is called once per frame
    void Update()
    {
        score.text = ScoreManager.Instance.Score.ToString();
        bestScore.text = ScoreManager.Instance.HighScore.ToString();
        coinsStore.text = StoreManager.Instance.Coins.ToString();
        coins.text = StoreManager.Instance.Coins.ToString();
      
    }

     void GameManager_GameStateChanged(GameState newState, GameState oldState)
     {
         
         if (newState == GameState.Playing)
         {
            ShowGameUI();            
         }
        else if (newState == GameState.Prepare)
        {
            ShowStartUI();
        }
        else if (newState == GameState.PreGameOver)
         {
             // Before game over, i.e. game potentially will be recovered
         }
         else if (newState == GameState.GameOver)
         {
            ShowGameOverUI();
         }
     }
   
       
    
    void OnScoreUpdated(int newScore)
    {
        
    }

    void Reset()
    {
        

        header.SetActive(false);
        title.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        tapToStart.SetActive(false);
        
        menuButtons.SetActive(false);
     

        // Enable or disable premium stuff
         bool enablePremium = PremiumFeaturesManager.Instance.enablePremiumFeatures;
         leaderboardBtn.SetActive(enablePremium);
         removeAdsBtn.SetActive(enablePremium);
         
        
    }
    
    public void NextCharacter()
    {
        // characterSprite.index++;
    }

    public void PrevCharacter()
    {
        // characterSprite.index--;
    }

    public void StartGame()
    {
        gameManager.StartGame();
      
    }

    public void EndGame()
    {
        gameManager.GameOver();
        
    }

    public void RestartGame()
    {
          gameManager.RestartGame(0f);
    }

    public void ShowStartUI()
    {
        storeButton.SetActive(true);
        menuButtons.SetActive(true);
        header.SetActive(true);
        score.gameObject.SetActive(false);
        menuButtonsOver.SetActive(false);
        title.gameObject.SetActive(true);
        tapToStart.SetActive(true);
        coins.gameObject.SetActive(true);
        diamond.gameObject.SetActive(true);
        coinsStore.gameObject.SetActive(false);
        bestScore.gameObject.SetActive(false);
       
        

    }

   
    public void ShowGameUI()
    {
        storeButton.SetActive(false);
        header.SetActive(true);
        title.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        tapToStart.SetActive(false);
        menuButtons.SetActive(false);
        menuButtonsOver.SetActive(false);
        bestScore.gameObject.SetActive(false);
        
    }

    public void ShowGameOverUI()
    {
        header.SetActive(true);
        title.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        tapToStart.SetActive(false);
   
        menuButtonsOver.SetActive(true);
        bestScore.gameObject.SetActive(true);
  

    }
    public void ShowStoreUI()
    {

        audioScript.Click();
            store.SetActive(true);
            header.SetActive(true);
            video.SetActive(true);
            title.gameObject.SetActive(false);
            score.gameObject.SetActive(false);
            bestScore.gameObject.SetActive(false);
            tapToStart.SetActive(false);
            menuButtons.SetActive(false);
            menuButtonsOver.SetActive(false);
            storeButton.SetActive(false);
            coins.gameObject.SetActive(false);
        diamond.gameObject.SetActive(false);
            coinsStore.gameObject.SetActive(true);
            bestScore.gameObject.SetActive(false);
            backToMenu.SetActive(true);
        
    }
    public void BackToMenu()
    {
        audioScript.Click();
        backToMenu.SetActive(false);
        storeButton.SetActive(true);
        store.SetActive(false);
        video.SetActive(false);
        ShowStartUI();
    }



    public void ShowLeaderboardUI()
    {
#if EASY_MOBILE
        if (GameServices.IsInitialized())
        {
            GameServices.ShowLeaderboardUI();
        }
        else
        {
#if UNITY_IOS
            NativeUI.Alert("Service Unavailable", "The user is not logged in to Game Center.");
#elif UNITY_ANDROID
            GameServices.Init();
#endif
        }
#endif
    }

    public void PurchaseRemoveAds()
    {
#if EASY_MOBILE
        InAppPurchaser.Instance.Purchase(InAppPurchaser.Instance.removeAds);
#endif
    }

    public void RestorePurchase()
    {
#if EASY_MOBILE
        InAppPurchaser.Instance.RestorePurchase();
#endif
    }

    public void ShareScreenshot()
    {
#if EASY_MOBILE
        ScreenshotSharer.Instance.ShareScreenshot();
#endif
    }

   

    public void RateApp()
    {
        Utilities.RateApp();
    }

    public void OpenInstagramDevelopersPage()
    {
        Application.OpenURL("https://www.instagram.com/yegorbondar/?hl=ru");
    }

    public void OpenFacebookPage()
    {
        Utilities.OpenFacebookPage();
    }

    public void ButtonClickSound()
    {
        Utilities.ButtonClickSound();
    }

    public void UpdateMuteButtons()
    {
        if (isMuted)
        {
            soundBtn.transform.GetChild(0).gameObject.SetActive(false);
            soundBtn.transform.GetChild(1).gameObject.SetActive(true);
            isMuted= !isMuted;
        }
        else
        {
            soundBtn.transform.GetChild(0).gameObject.SetActive(true);
            soundBtn.transform.GetChild(1).gameObject.SetActive(false);
            isMuted = !isMuted;
            audioScript.Click();
        }
    }

     bool IsPremiumFeaturesEnabled()
     {
         return PremiumFeaturesManager.Instance != null && PremiumFeaturesManager.Instance.enablePremiumFeatures;
     }
}
