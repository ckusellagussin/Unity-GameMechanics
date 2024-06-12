using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacter : MonoBehaviour
{
    private float movementSpeed = 4.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Horizontal"))
        {
            
            transform.Translate();
            
            
        }
        if (Input.GetButton("Vertical"))
        {
            
            
            
            
        }



    }
}
