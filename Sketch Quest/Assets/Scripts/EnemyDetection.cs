using UnityEngine;
using System.Collections;

public class EnemyDetection : MonoBehaviour{

    public bool watching;

    void Start(){
        watching = false;
    }



    void OnTriggerEnter(Collider col){
        Debug.Log(col);
        if(col.gameObject.tag == "Player"){
            Debug.Log ("Player Collided");
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