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
    public GameObject TutorialButt;
    //public GameObject GemButton;

    public static string Tutorial = "Tutorial";
    public static int Tutorial_Cond;

    private bool mute = false;

    private void Start()
    {
        Tutorial_Cond = PlayerPrefs.GetInt(Tutorial);

        if (Tutorial_Cond == 0)
        {
            TutorialButt.SetActive(true);
            pause = true;
            Player.isPause = true;
        }

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

    public void TutorDone()
    {
        Player.isPause = false;
        TutorialButt.SetActive(false);
        pause = true;
        Tutorial_Cond = 1;
        PlayerPrefs.SetInt(Tutorial, Tutorial_Cond);
    }

    public void Mute()
    {

        MainMenu.isMusic = !MainMenu.isMusic;
        setStateMusic(MainMenu.isMusic);
    }

    private void Update()
    {
       // if(audioSorse == null)
        //setStateMusic(MainMenu.isMusic);
    }

    public void setStateMusic(bool isMusic)
    {
        if (isMusic)
        {
            if (audioSorse == null) initMusic();
            audioSorse.Play();
            Sound.GetComponent<Image>().sprite = MuteCancel;
        }
        else
        {
            if (audioSorse == null) initMusic();
            audioSorse.Pause();
            Sound.GetComponent<Image>().sprite = MuteDone;
        }
    }

    void initMusic()
    {

        audioSorse = GetComponent<AudioSource>();
        audioSorse.clip = Song;
        audioSorse.Play();
    }
}
