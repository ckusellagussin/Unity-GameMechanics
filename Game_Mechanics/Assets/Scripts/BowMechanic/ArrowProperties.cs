using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ArrowProperties : MonoBehaviour
{
    public Rigidbody Arrow;
    public float angularSpeed = 2.0f;
    public float torque = 2f;
    public float arrowTipOffset = -5;
    
    private bool isStuck = false;
    

    // Start is called before the first frame update
    void Start()
    {

        Arrow = GetComponent<Rigidbody>();
       
    }

    private void OnCollisionEnter(Collision col)
    { 
        if (!isStuck)
        {

            if (col.gameObject.CompareTag("GroundX"))
            {
                Arrow.velocity = Vector3.zero;
                Arrow.angularVelocity = Vector3.zero;
                Arrow.isKinematic = true;
                
                Vector3 hitNormal = col.contacts[0].normal;
                transform.rotation = Quaternion.LookRotation(-hitNormal);

                Vector3 arrowPosition = col.contacts[0].point - transform.forward * arrowTipOffset;
                transform.position = arrowPosition;

                isStuck = true;
                
                Debug.Log(isStuck);
            }

        }
}

    // Update is called once per frame
    void Update()
    {

        float singleStep = angularSpeed * Time.deltaTime;
        transform.forward = Vector3.RotateTowards(transform.forward.normalized, Arrow.velocity.normalized, singleStep, 0.0f);

    }
}
