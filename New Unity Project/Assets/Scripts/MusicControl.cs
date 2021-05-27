using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{

    private AudioSource Music;
    private float MusicVolume = 100f;

    void Start()
    {
        Music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Music.volume = MusicVolume;
    }

    public void SetVolume(float Vol)
    {
        MusicVolume = Vol;
    }

}
