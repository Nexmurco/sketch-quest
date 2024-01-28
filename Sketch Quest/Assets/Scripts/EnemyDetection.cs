using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(1);
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