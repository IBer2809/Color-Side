using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SgLib;

public enum GameState
{
    Prepare,
    MenuState,
    Playing,
    Paused,
    PreGameOver,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public  int tries;


    public static event System.Action<GameState, GameState> GameStateChanged = delegate { };
    public SpawningObjects sp;
    public ParticleSystem UPDATESCORE;
    public ChangeCube changeCube;
    public ScoreManager scoreManager;

    public AudioScript audioScript;
    public AdManager ad;

    public GameState GameState
    {
        get
        {
            return _gameState;
        }
        private set
        {
            if (value != _gameState)
            {
                GameState oldState = _gameState;
                _gameState = value;

                GameStateChanged(_gameState, oldState);
            }
        }
    }

    [SerializeField]
    private GameState _gameState = GameState.Prepare;

    public static int GameCount
    {
        get { return _gameCount; }
        private set { _gameCount = value; }
    }

    private static int _gameCount = 0;

    [Header("Gameplay Config")]
    [Range(0.0025f, 0.25f)]
    public float refillCubeFrequency = 0.02f;

    [Range(0.0025f, 0.25f)]
    public float treeFrequency = 0.1f;

    [Range(0.0025f, 0.25f)]
    public float springFrequency = 0.1f;


    // store the bounds.x & bounds.y value of the sprite ( in this case , the  green cube - the ground)
    [HideInInspector] public float boundsX;
    [HideInInspector] public float boundsY;

    void Awake()
    {
        Instance = this;
        tries = 2;
    }



    void Start()
    {
        audioScript.AudioStart();
        GameState = GameState.Prepare;
        ScoreManager.Instance.Reset();
        SetCubes();

        Time.timeScale = 0f;




    }

    private void Update()
    {
        if (GameState == GameState.Playing)
        {
            Time.timeScale += 0.000100f;


        }

    }

    public void PlayerController_PlayerDied()
    {
        scoreManager.randomcolor = 0;

        StartCoroutine(ExecuteAfterTime(1.0F));


    }

    public void StartGame()
    {
        GameState = GameState.Playing;
        Time.timeScale = 1f;
        audioScript.Click();

    }

    public void GameOver()
    {
        Debug.Log(tries);
        if (tries == 0)
        {
            ad.LoseAd();
        }

        GameState = GameState.GameOver;

        if (ScoreManager.Instance.HasNewHighScore)
        {

            Instantiate(UPDATESCORE, new Vector3(0, 3, 0), Quaternion.identity);
            Instantiate(UPDATESCORE, new Vector3(1, 2.2f, 0), Quaternion.identity);
            Instantiate(UPDATESCORE, new Vector3(-1, 2.2f, 0), Quaternion.identity);
            audioScript.Firework();

        }

        Time.timeScale = 1f;


    }

    public void RestartGame(float delay = 0)
    {
        GameState = GameState.Prepare;
        sp.DestroyAll();
        tries--;
        Start();
    }

    public void SetCubes()
    {
        if (changeCube.GlobalCube == 1)
        {
            changeCube.SwapOne();
        }
        else if (changeCube.GlobalCube == 2)
        {
            changeCube.SwapTwo();
        }
        else if (changeCube.GlobalCube == 3)
        {
            changeCube.SwapThree();
        }
        else if (changeCube.GlobalCube == 4)
        {
            changeCube.SwapFour();
        }
        else if (changeCube.GlobalCube == 5)
        {
            changeCube.SwapFive();
        }
        else if (changeCube.GlobalCube == 6)
        {
            changeCube.SwapSix();
        }
        else if (changeCube.GlobalCube == 7)
        {
            changeCube.SwapSeven();
        }
        else if (changeCube.GlobalCube == 8)
        {
            changeCube.SwapEight();
        }
        else if (changeCube.GlobalCube == 9)
        {
            changeCube.SwapNine();
        }
        else if (changeCube.GlobalCube == 10)
        {
            changeCube.SwapTen();
        }
        else if (changeCube.GlobalCube == 11)
        {
            changeCube.SwapEleven();
        }
        else if (changeCube.GlobalCube == 12)
        {
            changeCube.SwapTwelve();
        }

    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        GameOver();
    }






}
