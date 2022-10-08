using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Music");
    }

    //Script play music
    //script di fold dengan shortcut ctrl + shift + [ atau ]
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Music diputar");
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }


    //Script play sfx
    //script di fold dengan shortcut ctrl + shift + [ atau ]
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sfx diputar");
        }

        else
        {
            sfxSource.PlayOneShot(s.clip);
            
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
        Debug.Log(musicSource.mute);
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
        Debug.Log(musicSource.mute);
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }


}
