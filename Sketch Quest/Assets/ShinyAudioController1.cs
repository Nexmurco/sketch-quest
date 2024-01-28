using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinyAudioController : MonoBehaviour
{
    private SoundController soundController;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundController = GameObject.Find("SoundController").GetComponent<SoundController>();
        audioSource.clip = soundController.shine;
        audioSource.loop = true;
        audioSource.volume = .7f;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
