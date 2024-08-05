using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ShootBow : MonoBehaviour
{
    
    public GameObject projectile;
    public Transform arrowSpawnPoint;
    public float launchVelocity = 300.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            
            GameObject Arrow = Instantiate(projectile, transform.position, transform.rotation);
            Arrow.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchVelocity, ForceMode.VelocityChange);

        }  
        
        
        
    }
}
