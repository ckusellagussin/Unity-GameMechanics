using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotateObject : MonoBehaviour
{

    
    public float speed = 30f;
    private bool isRotating = false;
    public float mouseMovement;
    public float currentMousePosition;
    private float startMousePosition;
    private float pitch = 0f;
    
    
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
            
            float currentMousePosition = Input.mousePosition.y;
            
            float mouseMovement = currentMousePosition - startMousePosition;
            
            pitch += mouseMovement * speed * Time.deltaTime;
            
            pitch = Mathf.Clamp(pitch, -35f, -15f);
            
            Quaternion newRotation = Quaternion.Euler(pitch, 0,0 );
            transform.localRotation = newRotation;
            
            startMousePosition = currentMousePosition;
        }

        
    }
}
