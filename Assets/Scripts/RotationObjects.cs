using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;


public class RotationObjects : MonoBehaviour
{
    public float lifeTime = 10f;
    public GameManager gameManager;
    

    void Update()
    {
        Rotation();
            Destroy(gameObject,lifeTime);
    }
    void Rotation()
    {

        if (Time.deltaTime == 0)
            return;
        else
        {
            transform.Rotate(Vector3.up*1.5f);
            transform.Rotate(Vector3.right* 1.5f);
        }
    }
    
    

}
