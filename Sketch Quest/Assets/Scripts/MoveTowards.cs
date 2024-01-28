using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public GameObject guard;
    public GameObject pointA;
    public GameObject pointB;
    public GameObject middlePoint;
    public GameObject player;

    private Vector3 target;

    public float speed;

    private bool targetisA;
    private bool isPatrol;
    private bool isChase;

    public bool watching;
    
    // Start is called before the first frame update
    void Start()
    {
        target = pointA.transform.position;
        targetisA = true;
        isPatrol = true;
        isChase = false;
        watching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPatrol)
        { 
            guard.transform.position = Vector3.MoveTowards(guard.transform.position, target ,speed * Time.deltaTime);
            guard.transform.LookAt(target);

            if (Vector3.Distance(guard.transform.position, target) < 0.001f)
            {
                if(targetisA)
                {
                    target = pointB.transform.position;
                    targetisA = false;
                    guard.transform.LookAt(target);
                }
                else
                {
                    target = pointA.transform.position;
                    targetisA = true;
                    gameObject.transform.LookAt(target);
                }
            }
        }
    }
        void OnTriggerEnter(Collider col)
    {
        Debug.Log(col);
        if(col.gameObject.tag == "Player")
        {
            Debug.Log ("Player Collided");
            watching = true;
        }
    }
    

    void OnTriggerExit(Collider col)
    {
        Debug.Log(col);
        if(col.gameObject.tag == "Player")
        {
            Debug.Log ("Player Stopped Colliding");
            watching = false;
        }
    }
}
