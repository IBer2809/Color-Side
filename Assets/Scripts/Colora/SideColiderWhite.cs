using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;

public class SideColiderWhite : MonoBehaviour
{
    public GameManager gameManager;
    public SpawningObjects so;
    public ChangeCube chc;
    public ScoreManager sc;

    public ParticleSystem particleSystemB;
    public ParticleSystem particleSystemG;
    public ParticleSystem particleSystemR;
    public ParticleSystem particleSystemW;
    public ParticleSystem particleSystemP;
    public ParticleSystem particleSystemS;
    public ParticleSystem particleSystemD;
    public ParticleSystem particleSystemBl;
    public AudioScript audioScript;

    

    private int chooseLerp;

    private Color greenColor, purpleColor, whiteColor, redColor, skyColor, blueColor;
    Color currentColor;
    MeshRenderer myRenderer;
    [Range(0, 2)] public float lerpTime;

    void Start()
    {
        blueColor = new Color(0.2980392f, 0.7019608f, 1f);
        greenColor = new Color(0.3537736f, 1f, 0.4266324f);
        whiteColor = new Color(0.8f, 0.8f, 0.8f);
        redColor = new Color(0.8867924f, 0.2049662f, 0.2049662f);
        skyColor = new Color(0.9292718f, 0.9339623f, 0.1365699f);
        purpleColor = new Color(0.8929f, 0.5047f, 1f);
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = whiteColor;
        currentColor = whiteColor;
        chooseLerp = 0;
    }

    public void Update()
    {
        checkRandomColor();
    }

    private void OnCollisionEnter(Collision collision)
    {
        AddSideScore(collision);
    }

    private void checkRandomColor()
    {
        if (sc.randomcolor == 1)
        {
            chooseLerp = sc.randomcolor;
            Lerp1();
        }
        else if (sc.randomcolor == 2)
        {
            chooseLerp = sc.randomcolor;
            Lerp2();
        }
        else if (sc.randomcolor == 3)
        {
            chooseLerp = sc.randomcolor;
            Lerp3();
        }
        else if (sc.randomcolor == 4)
        {
            chooseLerp = sc.randomcolor;
            Lerp4();
        }
        else if (sc.randomcolor == 5)
        {
            chooseLerp = sc.randomcolor;
            Lerp5();
        }
        else if (sc.randomcolor == 6)
        {
            chooseLerp = sc.randomcolor;
            Lerp6();
        }
        else
        {
            chooseLerp = sc.randomcolor;
            Lerp();
        }
    }


    public void Lerp()
    {
        gameObject.tag = "WhiteSide";
        currentColor = whiteColor;

        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, 5.0f);
    }
    public void Lerp1()
    {
        if (chooseLerp == 1)
        {
            gameObject.tag = "RedSide";
            currentColor = redColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp2()
    {
        if (chooseLerp == 2)
        {
            gameObject.tag = "SkySide";
            currentColor = skyColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp3()
    {
        if (chooseLerp == 3)
        {
            gameObject.tag = "BlueSide";
            currentColor = blueColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp4()
    {
        if (chooseLerp == 4)
        {
            gameObject.tag = "GreenSide";
            currentColor = greenColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp5()
    {
        if (chooseLerp == 5)
        {
            gameObject.tag = "PurpleSide";
            currentColor = purpleColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp6()
    {
        if (chooseLerp == 6)
        {
            gameObject.tag = "SkySide";
            currentColor = skyColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    private void AddSideScore(Collision collision)
    {
        if (gameObject.tag == "BlueSide" && collision.gameObject.CompareTag("BlueBall"))
        {
            so.SpanPartc(particleSystemB, collision);
            Destroy(GameObject.FindGameObjectWithTag("BlueBall"));
            ScoreManager.Instance.AddScore(1);
            audioScript.AudioCubeDestruction();
        }
        else if (gameObject.tag == "GreenSide" && collision.gameObject.tag == "GreenBall")
        {
            so.SpanPartc(particleSystemG, collision);
            Destroy(GameObject.FindGameObjectWithTag("GreenBall"));
            ScoreManager.Instance.AddScore(1);
            audioScript.AudioCubeDestruction();
        }
        else if (gameObject.tag == "PurpleSide" && collision.gameObject.tag == "PurpleBall")
        {
            so.SpanPartc(particleSystemP, collision);
            Destroy(GameObject.FindGameObjectWithTag("PurpleBall"));
            ScoreManager.Instance.AddScore(1);
            audioScript.AudioCubeDestruction();
        }
        else if (gameObject.tag == "WhiteSide" && collision.gameObject.tag == "WhiteBall")
        {
            so.SpanPartc(particleSystemW, collision);
            Destroy(GameObject.FindGameObjectWithTag("WhiteBall"));
            ScoreManager.Instance.AddScore(1);
            audioScript.AudioCubeDestruction();
        }
        else if (gameObject.tag == "RedSide" && collision.gameObject.tag == "RedBall")
        {
            so.SpanPartc(particleSystemR, collision);
            Destroy(GameObject.FindGameObjectWithTag("RedBall"));
            ScoreManager.Instance.AddScore(1);
            audioScript.AudioCubeDestruction();
        }
        else if (gameObject.tag == "SkySide" && collision.gameObject.tag == "SkyBall")
        {
            so.SpanPartc(particleSystemS, collision);
            Destroy(GameObject.FindGameObjectWithTag("SkyBall"));
            ScoreManager.Instance.AddScore(1);
            audioScript.AudioCubeDestruction();
        }
        else if (collision.gameObject.tag == "Coin")
        {
            so.SpanPartc(particleSystemD, collision);
            Destroy(GameObject.FindGameObjectWithTag("Coin"));
            StoreManager.Instance.AddCoins(10);
            audioScript.AudioDiamondDestruction();
        }
        else
            FinishGameBySide(collision);
    }

    private void FinishGameBySide(Collision collision)
    {
        if (collision.gameObject.tag == "BlueBall")
        {
            so.SpanPartc(particleSystemB, collision);
            so.SpanPartc1(particleSystemBl, collision);
            Destroy(GameObject.FindGameObjectWithTag("BlueBall"));
            chc.SetActiveAllFalse();
            audioScript.AudioFailureDestruction();
            gameManager.PlayerController_PlayerDied();
        }
        else if (collision.gameObject.tag == "GreenBall")
        {
            so.SpanPartc(particleSystemG, collision);
            so.SpanPartc1(particleSystemBl, collision);
            Destroy(GameObject.FindGameObjectWithTag("GreenBall"));
            chc.SetActiveAllFalse();
            audioScript.AudioFailureDestruction();
            gameManager.PlayerController_PlayerDied();
        }
        else if (collision.gameObject.tag == "PurpleBall")
        {
            so.SpanPartc(particleSystemP, collision);
            so.SpanPartc1(particleSystemBl, collision);
            Destroy(GameObject.FindGameObjectWithTag("PurpleBall"));
            chc.SetActiveAllFalse();
            audioScript.AudioFailureDestruction();
            gameManager.PlayerController_PlayerDied();
        }
        else if (collision.gameObject.tag == "WhiteBall")
        {
            so.SpanPartc(particleSystemW, collision);
            so.SpanPartc1(particleSystemBl, collision);
            Destroy(GameObject.FindGameObjectWithTag("WhiteBall"));
            chc.SetActiveAllFalse();
            audioScript.AudioFailureDestruction();
            gameManager.PlayerController_PlayerDied();
        }
        else if (collision.gameObject.tag == "RedBall")
        {
            so.SpanPartc(particleSystemR, collision);
            so.SpanPartc1(particleSystemBl, collision);
            Destroy(GameObject.FindGameObjectWithTag("RedBall"));
            chc.SetActiveAllFalse();
            audioScript.AudioFailureDestruction();
            gameManager.PlayerController_PlayerDied();
        }
        else if (collision.gameObject.tag == "SkyBall")
        {
            so.SpanPartc(particleSystemS, collision);
            so.SpanPartc1(particleSystemBl, collision);
            Destroy(GameObject.FindGameObjectWithTag("SkyBall"));
            chc.SetActiveAllFalse();
            audioScript.AudioFailureDestruction();
            gameManager.PlayerController_PlayerDied();
        }
    }
}
