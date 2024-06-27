using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class ThirdPersonCharacter : MonoBehaviour
{
    public float movementSpeed = 4.0f;
    private CharacterController cc;
    private Vector2 characterMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Player created");
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, gameObject.transform.position.y));
        Vector3 forward = mouseWorld - gameObject.transform.position;
        gameObject.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);


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
}
