using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using static ScinesDataBase;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    /*public GameObject SelectBottle;
    public GameObject SelectBottlePrem;*/

    public Sprite MuteCancel;
    public Sprite MuteDone;

    public GameObject Sound;
    public GameObject Shop;

    public string SoundCond = "SoundCond";
    public static int soundCond;

    private bool pause = false;

    public static bool isMusic = true;

    public AudioClip Song;
    private AudioSource audioSorse;

    //private bool mute = false;

    private void Start()
    {
        audioSorse = GetComponent<AudioSource>();
        audioSorse.clip = Song;
        audioSorse.Play();
        //soundCond = 1;
        //PlayerPrefs.SetInt(SoundCond, soundCond);

        setStateMusic(isMusic);
    }

    public void PlayGame()
    {
        Player.lose = false;
        SceneManager.LoadScene("Scene1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ToShop()
    {
        Shop.SetActive(true);
    }

    public void ToMenu()
    {
        Shop.SetActive(false);
    }

    public void Mute()
    {
        /* if (PlayerPrefs.GetInt(SoundCond) == 0)
         {
             audioSorse.Pause();
             soundCond = 1;
             PlayerPrefs.SetInt(SoundCond, soundCond);
             Sound.GetComponent<Image>().sprite = MuteDone;
         }
         else if (PlayerPrefs.GetInt(SoundCond) == 1)
         {
             audioSorse.Play();
             soundCond = 0;
             PlayerPrefs.SetInt(SoundCond, soundCond);
             Sound.GetComponent<Image>().sprite = MuteCancel;
         }*/
        isMusic = !isMusic;
        setStateMusic(isMusic);
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
