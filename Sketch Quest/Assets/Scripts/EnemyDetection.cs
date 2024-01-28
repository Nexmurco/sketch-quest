using UnityEngine;
using System.Collections;

public class EnemyDetection : MonoBehaviour{

    public bool watching;

    public GameObject guard;
    public GameObject middlePoint;
    public GameObject player;

    private Vector3 target;

    public float speed;

    void Start(){
        watching = false;
    }



    void OnTriggerEnter(Collider col){
        Debug.Log(col);
        if(col.gameObject.tag == "Player"){
            Debug.Log ("Player Collided");
            target = player.transform.position;
            guard.transform.position = Vector3.MoveTowards(guard.transform.position, target ,speed * Time.deltaTime);
            watching = true;
        }
    }
    void OnTriggerExit(Collider col){
        Debug.Log(col);
        if(col.gameObject.tag == "Player"){
            Debug.Log ("Player Stopped Colliding");
            watching = false;
        }
    }
}