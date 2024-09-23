using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowProperties : MonoBehaviour
{
    public Rigidbody Arrow;
    public float angularSpeed = 2.0f;
    public float torque = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float singleStep = angularSpeed * Time.deltaTime;
        transform.forward = Vector3.RotateTowards(transform.forward.normalized, Arrow.velocity.normalized, singleStep, 0.0f);

    }
}
