using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class ThirdPersonCharacter : MonoBehaviour
{

    [SerializeField] private LayerMask groundMask;
    public float movementSpeed = 6.0f;
    
    private CharacterController cc;
    private Vector2 characterMovement;
   // private Camera mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Player created");
        cc = GetComponent<CharacterController>();
      //  mainCamera = Camera.main;

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

    private void GetMousePosition()
    {

        Ray ray = Camera.main.ScreenPointToRay((Input.mousePosition));

        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, groundMask))
        {

            Vector3 direcion = (raycastHit.point - transform.position).normalized;
            direcion.z = 0;
            transform.forward = direcion;
            transform.LookAt(new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z));
            
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        MovePlayer();
        GetMousePosition();

    }
}
