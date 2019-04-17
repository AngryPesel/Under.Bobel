using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool pause = false;

    public AudioClip Song;
    private AudioSource audioSorse;

    public Sprite MuteCancel;
    public Sprite MuteDone;

    public GameObject Sound;

    private bool mute = false;

    private void Start()
    {
        audioSorse = GetComponent<AudioSource>();
        audioSorse.clip = Song;
        audioSorse.Play();
        Sound.GetComponent<Image>().sprite = MuteCancel;
        setStateMusic(MainMenu.isMusic);
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
        /*if (!mute)
        {
            audioSorse.Pause();
            mute = true;
            Sound.GetComponent<Image>().sprite = MuteDone;
        }
        else if (mute)
        {
            audioSorse.Play();
            mute = false;
            Sound.GetComponent<Image>().sprite = MuteCancel;
        }*/
        MainMenu.isMusic = !MainMenu.isMusic;
        setStateMusic(MainMenu.isMusic);
    }

    void setStateMusic(bool isMusic)
    {
        if (isMusic)
        {
            audioSorse.Play();
            Sound.GetComponent<Image>().sprite = MuteCancel;
        }
        else
        {
            audioSorse.Pause();
            Sound.GetComponent<Image>().sprite = MuteDone;
        }
    }
}
