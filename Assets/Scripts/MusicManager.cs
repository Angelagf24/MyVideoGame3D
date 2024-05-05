using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;
    public AudioSource musicSource; 

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            PlayMusic();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if (!musicSource.isPlaying)
        {
            PlayMusic();
        }
    }

    void PlayMusic()
    {
        if (musicSource != null)
        {
            musicSource.Play();
        }
    }
}