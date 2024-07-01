using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class ThirdPersonCharacter : MonoBehaviour
{
    public float movementSpeed = 6.0f;
    private CharacterController cc;
    private Vector2 characterMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Player created");
        cc = GetComponent<CharacterController>();

    }
    
    void MovePlayer()
    {

        Vector3 movement = new Vector3(characterMovement.x, 0.0f, characterMovement.y);
        cc.SimpleMove(movement * movementSpeed);

    }
    
    void OnMove(InputValue iv)
    {
        
        characterMovement = iv.Get<Vector2>();

    }

    void CharacterLook()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.LookAt(new Vector3(transform.position.x, mousePos.y, mousePos.z), Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
        MovePlayer();
        CharacterLook();

    }
}
