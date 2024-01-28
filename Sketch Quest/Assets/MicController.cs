using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MicController : MonoBehaviour
{

    private AudioClip clip;
    private string micName;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        micName = Microphone.devices[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(!Microphone.IsRecording(micName) && clip == null && Input.anyKeyDown){
            clip = Microphone.Start(micName, false, 10, 44100);
            Debug.Log("Recording");
        }
        else if(Microphone.IsRecording(micName) && Input.anyKeyDown){
            Microphone.End(micName);
            Debug.Log("Finished");
        }
        else if(clip != null && !Microphone.IsRecording(micName) && Input.anyKeyDown){
            Debug.Log("Playing Audio");
            source.PlayOneShot(clip, 1);
        }
    }
}
