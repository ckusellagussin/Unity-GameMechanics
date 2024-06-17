using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBow : MonoBehaviour
{

    public GameObject projectile;
    public float launchVelocity = 300.0f;
    public float launchX;
    public float launchz;
    
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
            Arrow.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(launchX,launchVelocity,launchz));


        }  
        
        
        
    }
}
