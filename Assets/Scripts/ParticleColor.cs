using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColor : MonoBehaviour
{
    MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    
    public void SetColor(Color color)
    {
        mesh.material.SetFloat("_Glossiness", 0f);
        mesh.material.color = color;
    }



}

