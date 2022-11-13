using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    private void Awake()
    {
        // DontDestroyOnLoad(gameObject);

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        PlayBackgroundSounds();
    }
    Sound s;

    void INITSounds()
    {

    }

    public void Play(string name)
    {
        s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            print(name + "Sound Not Found :(");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            print(name + "Sound Not Found :(");
            return;
        }
        s.source.Stop();
    }

    void PlayBackgroundSounds()
    {
        Play("Background Music");
        // Play("WaterDripping");
        // Play("FireSound");
    }


    public void SetSoundVolume(float val)
    {
        foreach (Sound s in sounds)
        {
            if (!s.isMusic)
            {
                s.source.volume = val;
            }
        }
    }
    public void ReduceSoundVolume()
    {
        foreach (Sound s in sounds)
        {
            if (s.source.volume > 0 && !s.isMusic)
            {
                s.source.volume -= 0.1f;
            }
        }
    }

    public void MuteSoundVolume(bool val)
    {
        foreach (Sound s in sounds)
        {
            if (!s.isMusic)
            {
                s.source.mute = val;
            }
        }
    }
    public void MuteMusicVolume(bool val)
    {
        foreach (Sound s in sounds)
        {
            if (s.isMusic)
            {
                s.source.mute = val;
            }
        }
    }



    public void IncreaseSoundVolume()
    {
        foreach (Sound s in sounds)
        {
            if (s.source.volume < 0.5f && !s.isMusic)
            {
                s.source.volume += 0.1f;
            }
        }
    }


    public void SetMusicVolume(float val)
    {
        foreach (Sound s in sounds)
        {
            if (s.isMusic)
            {
                s.source.volume = val;
            }
        }
    }

    public void ReduceMusicVolume()
    {
        foreach (Sound s in sounds)
        {
            if (s.source.volume > 0 && s.isMusic)
            {
                s.source.volume -= 0.1f;
                // print(s.source.volume);
            };
        }
    }

    public void IncreaseMusicVolume()
    {
        foreach (Sound s in sounds)
        {
            if (s.source.volume < 1f && s.isMusic)
            {
                s.source.volume += 0.1f;
                // print(s.source.volume);
            }
        }
    }

}
