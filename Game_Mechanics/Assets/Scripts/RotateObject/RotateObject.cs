using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotateObject : MonoBehaviour
{

    
    public float speed = 10f;
    private bool isRotating = false;
    public float mouseMovement;
    public float currentMousePosition;
    private float startMousePosition;
    private float pitch;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
     
        if (Input.GetMouseButtonDown(1))
        {

            isRotating = true;
            startMousePosition = Input.mousePosition.y;

        }

        else if (Input.GetMouseButtonUp(1))
        {

            isRotating = false;

        }



        if (isRotating)
        {
                
                currentMousePosition = Input.mousePosition.y;
                mouseMovement = currentMousePosition - startMousePosition;
                

                transform.Rotate(Vector3.right, -mouseMovement * speed * Time.deltaTime);
                
                startMousePosition = currentMousePosition;


                pitch = Mathf.Clamp(mouseMovement, -3000f, 3000f);
                transform.localRotation = quaternion.Euler(pitch);
             
        }

        
    }
}
