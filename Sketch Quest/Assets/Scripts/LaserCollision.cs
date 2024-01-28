using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col);
        if(col.gameObject.tag == "Player")
        {
           Debug.Log("Game Over Screen");
           SceneManager.LoadScene(1);
        }
    } 
}
