using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
        public GameObject laser;
        public GameObject pointA;
        public GameObject pointB;

        public float speed;

        private bool targetisA;

        private Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = pointA.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        laser.transform.position = Vector3.MoveTowards(laser.transform.position, target ,speed * Time.deltaTime);

        if (Vector3.Distance(laser.transform.position, target) < 0.001f)
        {
            if(targetisA)
            {
                target = pointB.transform.position;
                targetisA = false;
            }
            else
            {
                target = pointA.transform.position;
                targetisA = true;
            } 
        }
    }
}
