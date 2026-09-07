using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //[SerializeField] private AudioSource audioSource; for sfx handling...?
    [SerializeField] private AudioSource musicSource;

    //[SerializeField] private List<AudioClip> audioClips = new List<AudioClip>();
    public static AudioManager instance;

    void Start()
    {
        if (instance == null)
            instance = this;
        
        playBGM();
    }

    public void playBGM()
    {
        musicSource.Play();
    }
}
