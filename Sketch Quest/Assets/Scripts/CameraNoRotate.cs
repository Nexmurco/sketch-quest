using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNoRotate : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void LateUpdate() 
    {
        transform.rotation = Quaternion.identity;  
        transform.position = target.position + new Vector3(0.3f, 2, -3);
    } 
}
