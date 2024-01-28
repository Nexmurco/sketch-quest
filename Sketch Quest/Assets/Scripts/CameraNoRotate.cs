using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNoRotate : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void LateUpdate() 
    {
        transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);  
    } 
}
