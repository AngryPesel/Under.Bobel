using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool pause = false;

    public AudioClip Song;
    private AudioSource audioSorse;

    private bool mute = false;

    private void Start()
    {
        audioSorse = GetComponent<AudioSource>();
        audioSorse.clip = Song;
        audioSorse.Play();
    }

    public void PauseGame()
    {
        if (!pause)
        {
            Time.timeScale = 0;
            pause = true;
        }
        else if (pause)
        {
            Time.timeScale = 1;
            pause = false;
        }

    }

    public void Mute()
    {
        if (!mute)
        {
            audioSorse.Pause();
            mute = true;
        }
        else if (mute)
        {
            audioSorse.Play();
            mute = false;
        }
    }
}
