using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3f;
    public float x_distance = 0.0f;
    public float y_distance = 10.0f;
    public float z_distance = -20.0f;
    
    private Camera ;
    private Vector3 velocity = Vector3.zero;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        //Get camera position
        Vector3 targetPosition = target.TransformPoint(new Vector3(x_distance, y_distance, z_distance));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

    }
}
