using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackground : MonoBehaviour
{
    public Gradient c;
    Color color;
    float t = 0;
    float i = 0.001f;
    bool change = false;

    public GradientColorKey[] gck;
    public GradientAlphaKey[] gak;
    public GradientColorKey[] gtk;
    public GradientAlphaKey[] gok;
    public Camera cam;

    
    

    void Update()
    {
       
        Camera.main.backgroundColor = c.Evaluate(t);
        if (!change)
            t += i;
        else
            t -= i;
        if (t >= 1)
            change = true;
        if (t <= 0)
            change = false;
    }
}

