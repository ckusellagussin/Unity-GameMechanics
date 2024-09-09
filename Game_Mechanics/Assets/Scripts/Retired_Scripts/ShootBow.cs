using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ShootBow : MonoBehaviour
{
    
    [SerializeField] Rigidbody projectile;
    public Transform arrowSpawnPoint;
    public float launchVelocity = 300.0f;
    public float torque = 2f;
   
    
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            
            Rigidbody Arrow = Instantiate(projectile, transform.position, transform.rotation);
            Arrow.AddForce(transform.forward * launchVelocity, ForceMode.Force);
            Arrow.AddTorque(transform.forward * torque, ForceMode.Force);
            

        }  
        
       
    }

    
   
}
