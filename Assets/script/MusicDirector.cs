using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDirector : MonoBehaviour
{
    public AudioClip start_sound;
    public AudioClip button_sound;
    AudioSource Music;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        Music = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void start_sound_shot()
    {
        Music.PlayOneShot(start_sound);
    }

    public void button_sound_shot()
    {
        Music.PlayOneShot(button_sound);
    }
}
