using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
public class ChangingColor : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private int whatColorWillBe;
    private Color currentColor;
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        whatColorWillBe = Random.Range(1,7);
        if (meshRenderer != null)
        {
            switch (whatColorWillBe)
            {
                case 1:
                    Color purple = new Color(0.8929f, 0.5047f, 1f);
                    currentColor = purple;
                    gameObject.tag = "PurpleBall";
                    break;
                case 2:
                    Color red = new Color(1f, 0.3193f, 0.3160f);
                    currentColor = red;
                    gameObject.tag = "RedBall";
                    break;
                case 3:
                    Color white = new Color(0.8f, 0.8f, 0.8f);
                    currentColor = white;
                    gameObject.tag = "WhiteBall";
                    break;
                case 4:
                    Color blue = new Color(0.3726f, 0.7335f, 1f);
                    currentColor = blue;
                    gameObject.tag = "BlueBall";
                    break;
                case 5:
                    Color green = new Color(0.3537f, 1f,0.4266f);
                    currentColor = green;
                    gameObject.tag = "GreenBall";
                    break;
                case 6:
                    Color sky = new Color(0.9f, 0.9f, 0.2f);
                    currentColor = sky;
                    gameObject.tag = "SkyBall";
                    break;
            }
            meshRenderer.material.SetFloat("_Glossiness", 0f);
            meshRenderer.material.color = currentColor;
         

        }
        
    }

    
}
