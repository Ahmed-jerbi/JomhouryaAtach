using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour
{
    public AudioSource audiosource;
    public void StopAudioSource()
    {
        audiosource.Stop();
    }
}
