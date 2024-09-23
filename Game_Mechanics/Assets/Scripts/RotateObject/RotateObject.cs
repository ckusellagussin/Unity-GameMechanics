using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    
    public float speed = 15f;
    private bool isRotating = false;
    public float minRotation;
    public float maxRotation;
    public float radius;
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
            startMousePosition = Input.mousePosition.x;

        }

        else if (Input.GetMouseButtonUp(1))
        {

            isRotating = false;

        }

        
        
        if (isRotating)
        {
            float currentMousePosition = Input.mousePosition.y;
            float mouseMovement = currentMousePosition - startMousePosition;
            
            transform.Rotate(Vector3.right, -mouseMovement * speed * Time.deltaTime);
        
            startMousePosition = currentMousePosition;

            currentMousePosition = Mathf.Clamp(transform.eulerAngles.x, -45, 45);
            Debug.Log(currentMousePosition);

        }

    }
}
