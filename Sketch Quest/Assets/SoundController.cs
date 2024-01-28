using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private MicController micControllerScript;
    private SoundController sCtrl;

    public AudioClip sneak;
    public AudioClip shine;
    public AudioClip ouch;
    public AudioClip water;
    public AudioClip danger;
    public AudioClip quip;
    
    // Start is called before the first frame update
    void Awake()
    {
        micControllerScript = GameObject.Find("MicController").GetComponent<MicController>();
        SoundController = GameObject.Find("SoundController").GetComponent<SoundController>();
        Debug.Log("YO HEAR ME");
        sneak = micControllerScript.clip1;
        shine = micControllerScript.clip2;
        ouch = micControllerScript.clip3;
        water = micControllerScript.clip4;
        danger = micControllerScript.clip5;
        quip = micControllerScript.clip6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
