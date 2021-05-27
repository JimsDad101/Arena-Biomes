using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource SFXPlayer;
    public AudioSource soundTrack;

    public AudioClip Music;

    public void Start()
    {
        soundTrack.clip = Music;
        soundTrack.Play();
    }

    public void OnGameEvent(string gameEvent)
    {

    }
}

