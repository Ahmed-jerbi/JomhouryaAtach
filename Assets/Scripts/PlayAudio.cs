using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip audioClip;
    private UnityEngine.Events.UnityEvent MarkerFound;
    void Start()
    {
        //attach to the TriggerFound  Event of Vuforia to PlayAudioClip
        MarkerFound = GetComponent<DefaultObserverEventHandler>().OnTargetFound;
        MarkerFound.AddListener(PlayAudioClip);
    }

    void PlayAudioClip()
    {
        Debug.Log("play audio");
        audiosource.clip =audioClip;
        audiosource.Play();
    }
}
