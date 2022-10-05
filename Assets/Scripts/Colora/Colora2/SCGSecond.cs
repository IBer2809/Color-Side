using SgLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCGSecond : MonoBehaviour
{
    public ScoreManager sc;
    private int chooseLerp;
    private Color greenColor, purpleColor, whiteColor, redColor, skyColor, blueColor;
    Color currentColor;
    MeshRenderer myRenderer;
    [Range(0, 2)] public float lerpTime;


    public void Start()
    {
        blueColor = new Color(0.5990566f, 0.8338947f, 1f);
        greenColor = new Color(0.5246529f, 0.8490566f, 0.5583572f);
        whiteColor = new Color(0.735849f, 0.735849f, 0.735849f);
        redColor = new Color(0.9433962f, 0.4213596f, 0.4138483f);
        skyColor = new Color(0.9803069f, 0.990566f, 0.5186454f);
        purpleColor = new Color(0.4286271f, 0.2382966f, 0.4811321f);
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = blueColor;
        currentColor = blueColor;
        chooseLerp = 0;
    }

    public void Update()
    {
        checkRandomColor();
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
        gameObject.tag = "GreenSide";
        currentColor = greenColor;

        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, 5.0f);
    }
    public void Lerp1()
    {
        if (chooseLerp == 1)
        {
            gameObject.tag = "PurpleSide";
            currentColor = purpleColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp2()
    {
        if (chooseLerp == 2)
        {
            gameObject.tag = "WhiteSide";
            currentColor = whiteColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp3()
    {
        if (chooseLerp == 3)
        {
            gameObject.tag = "RedSide";
            currentColor = redColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp4()
    {
        if (chooseLerp == 4)
        {
            gameObject.tag = "SkySide";
            currentColor = skyColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp5()
    {
        if (chooseLerp == 5)
        {
            gameObject.tag = "BlueSide";
            currentColor = blueColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }

    public void Lerp6()
    {
        if (chooseLerp == 6)
        {
            gameObject.tag = "WhiteSide";
            currentColor = whiteColor;
        }
        myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, lerpTime * Time.deltaTime);
    }
}
