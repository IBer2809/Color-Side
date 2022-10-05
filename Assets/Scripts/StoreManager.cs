using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
    {
    public static StoreManager Instance { get; private set; }
    public ChangeCube changeCube;
   

    public int CubeBuyed2 { get; private set; }

    public int CubeBuyed3 { get; private set; }

    public int CubeBuyed4 { get; private set; }

    public int CubeBuyed5 { get; private set; }

    public int CubeBuyed6 { get; private set; }

    public int CubeBuyed7 { get; private set; }

    public int CubeBuyed8 { get; private set; }

    public int CubeBuyed9 { get; private set; }

    public int CubeBuyed10 { get; private set; }

    public int CubeBuyed11 { get; private set; }

    public int CubeBuyed12 { get; private set; }

    public int Coins { get; private set; }

   
    
    public static event Action<int> UpdateCubeBuyed2 = delegate { };
    public static event Action<int> UpdateCubeBuyed3 = delegate { };
    public static event Action<int> UpdateCubeBuyed4 = delegate { };
    public static event Action<int> UpdateCubeBuyed5 = delegate { };
    public static event Action<int> UpdateCubeBuyed6 = delegate { };
    public static event Action<int> UpdateCubeBuyed7 = delegate { };
    public static event Action<int> UpdateCubeBuyed8 = delegate { };
    public static event Action<int> UpdateCubeBuyed9 = delegate { };
    public static event Action<int> UpdateCubeBuyed10 = delegate { };
    public static event Action<int> UpdateCubeBuyed11 = delegate { };
    public static event Action<int> UpdateCubeBuyed12 = delegate { };

    public static event Action<int> CoinsUpdated = delegate { };


    
    private const string CUBEBUYED2 = "CUBEBUYED2";
    private const string CUBEBUYED3 = "CUBEBUYED3";
    private const string CUBEBUYED4 = "CUBEBUYED4";
    private const string CUBEBUYED5 = "CUBEBUYED5";
    private const string CUBEBUYED6 = "CUBEBUYED6";
    private const string CUBEBUYED7 = "CUBEBUYED7";
    private const string CUBEBUYED8 = "CUBEBUYED8";
    private const string CUBEBUYED9 = "CUBEBUYED9";
    private const string CUBEBUYED10 = "CUBEBUYED10";
    private const string CUBEBUYED11 = "CUBEBUYED11";
    private const string CUBEBUYED12 = "CUBEBUYED12";
    

    public  GameObject button1 ;
    public  GameObject button2 ;
    public  GameObject button3 ;
    public  GameObject button4 ;
    public  GameObject button5 ;
    public  GameObject button6 ;
    public  GameObject button7 ;
    public  GameObject button8 ;
    public  GameObject button9 ;
    public  GameObject button10;
    public  GameObject button11;
    public  GameObject button12;

    public Image cantbuyimg;

    Animator cantBuy;



    private const string COINS = "COINS";

    
    void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        cantBuy = cantbuyimg.GetComponent<Animator>();
        Reset();
        
    }
    private void Update()
    {
        
        if (CubeBuyed2 > 200)
        {
            button2.transform.GetChild(0).gameObject.SetActive(true);
            button2.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed3 > 200)
        {
            button3.transform.GetChild(0).gameObject.SetActive(true);
            button3.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed4 > 200)
        {
            button4.transform.GetChild(0).gameObject.SetActive(true);
            button4.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed5 > 200)
        {
            button5.transform.GetChild(0).gameObject.SetActive(true);
            button5.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed6 > 200)
        {
            button6.transform.GetChild(0).gameObject.SetActive(true);
            button6.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed8 > 200)
        {
            button8.transform.GetChild(0).gameObject.SetActive(true);
            button8.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed9 > 200)
        {
            button9.transform.GetChild(0).gameObject.SetActive(true);
            button9.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed10 > 200)
        {
            button10.transform.GetChild(0).gameObject.SetActive(true);
            button10.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed11 > 200)
        {
            button11.transform.GetChild(0).gameObject.SetActive(true);
            button11.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed12 > 200)
        {
            button12.transform.GetChild(0).gameObject.SetActive(true);
            button12.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (CubeBuyed7 > 200)
        {
            button7.transform.GetChild(0).gameObject.SetActive(true);
            button7.transform.GetChild(1).gameObject.SetActive(false);
        }

    }
        private void Reset()
    {
        
        CubeBuyed2 = PlayerPrefs.GetInt(CUBEBUYED2, 0);
        CubeBuyed3 = PlayerPrefs.GetInt(CUBEBUYED3, 0);
        CubeBuyed4 = PlayerPrefs.GetInt(CUBEBUYED4, 0);
        CubeBuyed5 = PlayerPrefs.GetInt(CUBEBUYED5, 0);
        CubeBuyed6 = PlayerPrefs.GetInt(CUBEBUYED6, 0);
        CubeBuyed7 = PlayerPrefs.GetInt(CUBEBUYED7, 0);
        CubeBuyed8 = PlayerPrefs.GetInt(CUBEBUYED8, 0);
        CubeBuyed9 = PlayerPrefs.GetInt(CUBEBUYED9, 0);
        CubeBuyed10 = PlayerPrefs.GetInt(CUBEBUYED10, 0);
        CubeBuyed11 = PlayerPrefs.GetInt(CUBEBUYED11, 0);
        CubeBuyed12 = PlayerPrefs.GetInt(CUBEBUYED12, 0);
        Coins = PlayerPrefs.GetInt(COINS, 0);
        
    }

    public void OpenCube1(int coins)
    {
        changeCube.SwapOne();
       
    }
    public void OpenCube2(int coins)
    {
        if (CubeBuyed2 > coins)
        {

            changeCube.SwapTwo();
           
        }
        else if (Coins >= 200)
        {

            CubeBuyed2 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED2, CubeBuyed2);
            UpdateCubeBuyed2(CubeBuyed2);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube3(int coins)
    {
        if (CubeBuyed3 > coins)
        {
            changeCube.SwapThree();
            
        }
        else if(Coins>=200)
        {
            CubeBuyed3 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED3, CubeBuyed3);
            UpdateCubeBuyed3(CubeBuyed3);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }

    public void OpenCube4(int coins)
    {
        if (CubeBuyed4 > coins)
        {
            changeCube.SwapFour();
          
        }
        else if (Coins >= 200)
        {
            CubeBuyed4 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED4, CubeBuyed4);
            UpdateCubeBuyed4(CubeBuyed4);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube5(int coins)
    {
        if (CubeBuyed5 > coins)
        {
            changeCube.SwapFive();
        }
        else if (Coins >= 200)
        {
            CubeBuyed5 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED5, CubeBuyed5);
            UpdateCubeBuyed5(CubeBuyed5);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube6(int coins)
    {
        if (CubeBuyed6 > coins)
        {
            changeCube.SwapSix();
        }
        else if (Coins >= 200)
        {
            CubeBuyed6 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED6, CubeBuyed6);
            UpdateCubeBuyed6(CubeBuyed6);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube7(int coins)
    {
        if (CubeBuyed7 > coins)
        {
            changeCube.SwapSeven();
        }
        else if (Coins >= 200)
        {
            CubeBuyed7 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED7, CubeBuyed7);
            UpdateCubeBuyed7(CubeBuyed7);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube8(int coins)
    {
        if (CubeBuyed8 > coins)
        {
            changeCube.SwapEight();
        }
        else if (Coins >= 200)
        {
            CubeBuyed8 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED8, CubeBuyed8);
            UpdateCubeBuyed8(CubeBuyed8);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube9(int coins)
    {
        if (CubeBuyed9 > coins)
        {
            changeCube.SwapNine();
        }
        else if (Coins >= 200)
        {
            CubeBuyed9 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED9, CubeBuyed9);
            UpdateCubeBuyed9(CubeBuyed9);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube10(int coins)
    {
        if (CubeBuyed10 > coins)
        {
            changeCube.SwapTen();
        }
        else if (Coins >= 200)
        {
            CubeBuyed10 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED10, CubeBuyed10);
            UpdateCubeBuyed10(CubeBuyed10);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube11(int coins)
    {
        if (CubeBuyed11 > coins)
        {
            changeCube.SwapEleven();
        }
        else if (Coins >= 200)
        {
            CubeBuyed11 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED11, CubeBuyed11);
            UpdateCubeBuyed11(CubeBuyed11);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
    public void OpenCube12(int coins)
    {
        if (CubeBuyed12 > coins)
        {
            changeCube.SwapTwelve();
        }
        else if (Coins >= 200)
        {
            CubeBuyed12 = coins + 1;
            PlayerPrefs.SetInt(CUBEBUYED12, CubeBuyed12);
            UpdateCubeBuyed12(CubeBuyed12);
            Instance.Coins -= 200;
            PlayerPrefs.SetInt(COINS, Coins);
        }
        else
            CantBuy();
    }
   
    public void CantBuy()
    {
        cantBuy.Play("notenoughdiamods");
    }
    public void AddCoins(int coin)
    {
        Coins += coin;
        PlayerPrefs.SetInt(COINS, Coins);
        CoinsUpdated(Coins);
    }
}

