using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SgLib;
public class ChangeCube : MonoBehaviour
{
    public static ChangeCube Instance { get; private set; }
    public GameObject  CubeByued1, CubeByued2, CubeByued3, CubeByued4, CubeByued5, CubeByued6, CubeByued7, CubeByued8, CubeByued9, CubeByued10, CubeByued11, CubeByued12;

    public int GlobalCube { get; private set; }
    public static event Action<int> SetGlobalCube = delegate { };
    private const string GLOBALCUBE = "GLOBALCUBE";
    public AudioScript audioScript;
    private void Awake()
    {
        GlobalCube = PlayerPrefs.GetInt(GLOBALCUBE, 0);
        
    }
    void Start()
    {
        
        if (GlobalCube == 1 || GlobalCube == 0)
        {
            SwapOne();
        }
        if (GlobalCube == 2)
        {
            SwapTwo();
        }
        if (GlobalCube == 3)
        {
            SwapThree();
        }
        if (GlobalCube == 4)
        {
            SwapFour();
        }
        if (GlobalCube == 5)
        {
            SwapFive();
        }
        if (GlobalCube == 6)
        {
            SwapSix();
        }
        if (GlobalCube == 7)
        {
            SwapSeven();
        }
        if (GlobalCube == 8)
        {
            SwapEight();
        }
        if (GlobalCube == 9)
        {
            SwapNine();
        }
        if (GlobalCube == 10)
        {
            SwapTen();
        }
        if (GlobalCube == 11)
        {
            SwapEleven();
        }
        if (GlobalCube == 12)
        {
            SwapTwelve();
        }
    }
    public void SwapOne()
    {
        audioScript.Click();
        GlobalCube = 1;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued1.SetActive(true);
            CubeByued1.transform.eulerAngles = new Vector3(90, -90, 0);
            CubeByued2.SetActive(false);
            CubeByued3.SetActive(false);
            CubeByued4.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapTwo()
    {
        audioScript.Click();
        GlobalCube = 2;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued2.SetActive(true);
            CubeByued2.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
            CubeByued3.SetActive(false);
            CubeByued4.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapThree()
    {
        audioScript.Click();
        GlobalCube = 3;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued3.SetActive(true);
            CubeByued3.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
            CubeByued2.SetActive(false);
            CubeByued4.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapFour()
    {
        audioScript.Click();
        GlobalCube = 4;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued4.SetActive(true);
        CubeByued4.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapFive()
    {
        audioScript.Click();
        GlobalCube = 5;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued5.SetActive(true);
        CubeByued5.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapSix()
    {
        audioScript.Click();
        GlobalCube = 6;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued6.SetActive(true);
        CubeByued6.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapSeven()
    {
        audioScript.Click();
        GlobalCube = 7;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued7.SetActive(true);
        CubeByued7.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapEight()
    {
        audioScript.Click();
        GlobalCube = 8;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued8.SetActive(true);
        CubeByued8.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapNine()
    {
        audioScript.Click();
        GlobalCube = 9;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued9.SetActive(true);
        CubeByued9.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapTen()
    {
        audioScript.Click();
        GlobalCube = 10;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued10.SetActive(true);
        CubeByued10.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapEleven()
    {
        audioScript.Click();
        GlobalCube = 11;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued11.SetActive(true);
        CubeByued11.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued8.SetActive(false);
        CubeByued12.SetActive(false);
    }
    public void SwapTwelve()
    {
        audioScript.Click();
        GlobalCube = 12;
        PlayerPrefs.SetInt(GLOBALCUBE, GlobalCube);
        SetGlobalCube(GlobalCube);
        CubeByued12.SetActive(true);
        CubeByued12.transform.eulerAngles = new Vector3(90, -90, 0);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued8.SetActive(false);
    }

    public void SetActiveAllFalse()
    {
        CubeByued12.SetActive(false);
        CubeByued1.SetActive(false);
        CubeByued3.SetActive(false);
        CubeByued2.SetActive(false);
        CubeByued5.SetActive(false);
        CubeByued6.SetActive(false);
        CubeByued7.SetActive(false);
        CubeByued4.SetActive(false);
        CubeByued9.SetActive(false);
        CubeByued10.SetActive(false);
        CubeByued11.SetActive(false);
        CubeByued8.SetActive(false);
    }
    
}
