using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundEffect : MonoBehaviour
{
    public AudioSource soundFX;
    public AudioClip sound;
    
    public void Sound()
    {
        soundFX.PlayOneShot(sound);
    }
}
