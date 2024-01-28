using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAudioController : MonoBehaviour
{
    private SoundController soundController;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundController = GameObject.Find("SoundController").GetComponent<SoundController>();
        audioSource.clip = soundController.danger;
        audioSource.loop = true;
        audioSource.volume = .3f;
        Invoke("MyFunction", Random.Range(0,1));
        
    }

    // Update is called once per frame
    void MyFunction(){
        audioSource.Play();  
    }
}
