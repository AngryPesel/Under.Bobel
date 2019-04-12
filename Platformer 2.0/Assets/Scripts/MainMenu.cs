using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ScinesDataBase;

public class MainMenu : MonoBehaviour
{
    public GameObject Shop;

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
