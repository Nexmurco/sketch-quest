using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour{
    public MeshCollider sight;

    public bool watching;

    void Start(){
        watching = false;
    }

    void OnTriggerEnter(Collider sight){
        Debug.Log ("Colliding");
        if(sight.gameObject.tag == "Player"){
            Debug.Log ("Player Collided");
            watching = true;
        }
    }
    void OnTriggerExit(Collider sight){
        Debug.Log ("Stopped colliding");
        if(sight.gameObject.tag == "Player"){
            Debug.Log ("Player Collided");
            watching = false;
        }
    }
}