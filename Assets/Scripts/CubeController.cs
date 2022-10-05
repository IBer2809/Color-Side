using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    public float rotationSpeed = 20f;


    private Vector3 lastTapPosition;
    private Vector3 startMove;


    void OnMouseDrag() {
        if (Time.deltaTime == 0)
        {
            return;
        }
        else { 
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
                float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;

                transform.RotateAround(Vector3.up, -rotationX);
                transform.RotateAround(Vector3.right, rotationY);
        }
        
    
        
    }
   


}

