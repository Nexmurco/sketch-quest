using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log ("Player Collided");
            SceneManager.LoadScene(2);
        }
    }
}
