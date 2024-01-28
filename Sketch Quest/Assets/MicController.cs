using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MicController : MonoBehaviour
{
    private int stage = 0;
    private bool updateStage = true;

    private AudioClip activeClip;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;

    private string micName;
    public AudioSource source;

    public GameObject indicator;
    public GameObject prompt;

    private TextMeshProUGUI  indicatorText;
    private TextMeshProUGUI  promptText;
    // Start is called before the first frame update

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        micName = Microphone.devices[0];
        indicatorText = indicator.GetComponent<TextMeshProUGUI >();
        promptText = prompt.GetComponent<TextMeshProUGUI >();
        indicatorText.text = "Click to Record";
        activeClip = clip1;
    }

    AudioClip RecordingUpdate(AudioClip c){
        if(!Microphone.IsRecording(micName) && c == null && Input.anyKeyDown){
            c = Microphone.Start(micName, false, 10, 44100);
            Debug.Log("Recording");
            indicatorText.text = "Recording in Progress";
            indicatorText.color = new Color(1, 0, 0, 1);
        }
        else if(Microphone.IsRecording(micName) && Input.anyKeyDown){
            Microphone.End(micName);
            indicatorText.text = "Recording Complete";
            Debug.Log("Finished");
            indicatorText.color = new Color(0,0,0,1);
        }
        else if(c != null && !Microphone.IsRecording(micName) && Input.anyKeyDown){
            Debug.Log("Playing Audio");
            indicatorText.text = "Click to Record";
            c.name = "Clip" + stage.ToString();
            updateStage = true;
            stage++;
        }
        return c;
    }

    void ChangeText(string s){

    }

    // Update is called once per frame
    void Update()
    {
        if(stage == 0){
            if(updateStage){
                updateStage=false;
                //set text stuff
                promptText.text = "Record the sound of someone being SNEAKY.";
            }
            clip1 = RecordingUpdate(clip1);
        }
        else if (stage == 1){
            if(updateStage){
                

                updateStage=false;
                //set text stuff
                promptText.text = "Record the sound of something being shiny.";
            }
                clip2 = RecordingUpdate(clip2);
        }
        else if (stage == 2){
            if(updateStage){
                
                updateStage=false;
                //set text stuff
                promptText.text = "Record the sound of touching something hot.";
            }
            clip3 = RecordingUpdate(clip3);
        }
        else if (stage == 3){
            if(updateStage){
               
                updateStage=false;
                //set text stuff
                promptText.text = "Record the sound a medium amount of water makes.";
            }
            clip4 = RecordingUpdate(clip4);
        }
        else if (stage == 4){
            if(updateStage){
                
                updateStage=false;
                //set text stuff
                promptText.text = "Record a dangerous sound.";
            }
            clip5 = RecordingUpdate(clip5);
        }
        else if (stage == 5){
            if(updateStage){
                updateStage=false;
                //set text stuff
                promptText.text = "Record a walkie-talkie quip.";
            }
            clip6 = RecordingUpdate(clip6);
        }
        else if (stage == 6 && updateStage){
            SceneManager.LoadScene(5);
        }
    }
}
