using UnityEngine;
using System.Collections;

public class ButtonDetection : MonoBehaviour{

    private bool active;
    private bool setActive;
    private bool setInactive;


    public Color activeColor;
    public Color inactiveColor;

    private MeshRenderer mesh;

    public Renderer r;

    // void AssignColor(Color c){
    //     Color[] colors = new Color[mesh.vertices.Length];
    //     for (int i = 0; i < colors.Length; i++)
    //         colors[i] = inactiveColor;
    //     // assign the array of colors to the Mesh.
    //     mesh.colors = colors;
    // }

    void Start(){
        active = false;
        setActive = false;
        mesh = GetComponent<MeshRenderer>();
        mesh.material.SetColor("_Color", inactiveColor);
        //AssignColor(inactiveColor);
    }

    void Update(){
        if(!active && setActive){
            active = true;
            setActive = false;
            mesh.material.SetColor("_Color", activeColor);
        }
        else if (active && setInactive){
            active = false;
            setInactive = false;
            mesh.material.SetColor("_Color", inactiveColor);
        }
    }

    void OnTriggerEnter(Collider col){
        Debug.Log(col);
        if(col.gameObject.tag == "Player"){
            Debug.Log ("Player Collided");
            setActive = true;
        }
    }
    void OnTriggerExit(Collider col){
        Debug.Log(col);
        if(col.gameObject.tag == "Player"){
            Debug.Log ("Player Stopped Colliding");
            setInactive = true;
        }
    }
}