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
    
    // Update is called once per frame
    void Update()
    {

        launchVelocity = Mathf.Clamp(launchVelocity, 130f, 350f);
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            launchVelocity += 10;

        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {

            launchVelocity -= 10;

        }

        if (Input.GetButtonDown("Fire1"))
        {
            
            Rigidbody Arrow = Instantiate(projectile, transform.position, transform.rotation);
            Arrow.AddForce(transform.forward * launchVelocity, ForceMode.Force);
           
        }  
        
       
    }

    
   
}
