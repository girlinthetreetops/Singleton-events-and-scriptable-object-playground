using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Singleton Business
    public static AudioManager Intance { get; private set; }
    private void Awake()
    {
        if (Intance != null && Intance != this)
        {
            Destroy(this);
        } else
        {
            Intance = this;
        }

        audioSource = GetComponent<AudioSource>();
    }

    //Let other script pass any sound to be played
    private AudioSource audioSource;

    public void PlaySound(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }

}

//would not work with multiple sounds, make the audiosource on whatever makes it. 
//doesnt need to be a singleton. but you could have one for background music.
