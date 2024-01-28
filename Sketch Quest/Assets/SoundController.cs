using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public MicController micControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        micControllerScript = GameObject.Find("MicController").GetComponent<MicController>();
        Debug.Log("YO HEAR ME");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
