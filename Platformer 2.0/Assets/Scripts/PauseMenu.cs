using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool pause = false;

    public AudioClip Song;
    private AudioSource audioSorse;

	public static int iteration;

    public Sprite MuteCancel;
    public Sprite MuteDone;

	/*public Sprite Replay;
	public Sprite Continues;
	public Sprite DubleGem;*/

    public GameObject Sound;
	//public GameObject GemButton;

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
			Player.isPause = true;
        }
        else if (pause)
        {
            Time.timeScale = 1;
            pause = false;
			Player.isPause = false;
		}

    }

    public void Mute()
    {

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
