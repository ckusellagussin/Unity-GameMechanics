using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Arrow : MonoBehaviour
{
    public GameObject arrow;
    public bool isKinematic = true;
    public bool gravityEnabled = true;
    public float shootVelocity = 300f;
    
    Rigidbody aRigidbody;
   
     
    // Start is called before the first frame update
    void Start()
    {
        
        aRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
         //   transform.SetParent(null);
         //   aRigidbody.isKinematic = false;
            GameObject Arrow = Instantiate(arrow, arrow.transform.position, arrow.transform.rotation);
            aRigidbody.AddRelativeForce(transform.forward * shootVelocity);
            
        }
        
        
    }
}
