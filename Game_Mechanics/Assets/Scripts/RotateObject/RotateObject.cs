using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotateObject : MonoBehaviour
{

    
    public float speed = 10f;
    public float pitch = 0f;
    private bool isRotating = false;
    public float mouseMovement;
    public float currentMousePosition;
    private float startMousePosition;
    
    
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
            
            transform.localRotation = Mathf.Clamp(currentMousePosition, -30, 30);

        }

        


    }
}
