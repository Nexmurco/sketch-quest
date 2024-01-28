using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAudioController : MonoBehaviour
{
    private SoundController soundController;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundController = GameObject.Find("SoundController").GetComponent<SoundController>();
        audioSource.clip = soundController.water;
        audioSource.loop = true;
        audioSource.volume = .2f;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
