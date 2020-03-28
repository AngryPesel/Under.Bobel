using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine.UI;


public class RestartMenu : MonoBehaviour
{
    public GameObject GemADS;
	public GameObject restartButton;
	public GameObject menuButton;

	public static int coef = 0;

    public static int BestScore;
    public static int SummScore;
    public static int GemScore;

//	public GameObject GemButton;
	public Sprite Replay;
	public Sprite Continues;
	public Sprite DubleGem;

	public static string BEST_SCORE = "saveScore";
    public static string SUMM_SCORE = "ScoreSumm";
    public static string SUMM_GEM_SCORE = "GemScore";

	private int iteration = 0;

    private void Start()
    {
		iteration = 0;

		GemADS.GetComponent<Image>().sprite = Replay;

		GemADS.SetActive(true);
        coef = 0;
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3110962", false);
        }
        else Debug.Log("Platform is not supported");
    }

    private void Update()
    {
        if (Player.deadscore % 5 == 0)
        {
            if (Advertisement.IsReady(""))
            {
                Advertisement.Show("");
                Player.deadscore++;
            }
        }
        if (Player.gemScore == 0 && iteration == 2)
        {
            GemADS.SetActive(false);
        }
    }

    public void WatchADS()
    {
		switch (iteration)
		{
			case 0:
				Advertisement.Show("rewardedVideo");
				GemADS.GetComponent<Image>().sprite = Continues;
				//	GemADS.SetActive(false);

				restartButton.SetActive(false);
				menuButton.SetActive(false);
                Player.anim.SetBool("Dead", false);
                break;
			case 1:
				GemADS.GetComponent<Image>().sprite = DubleGem;
				Player.isPause = false;
                Player.anim.SetBool("Dead", false);
                restartButton.SetActive(true);
				menuButton.SetActive(true);
				break;
			case 2:
					if (Advertisement.IsReady("rewardedVideo"))
					{
					Advertisement.Show("rewardedVideo");
					GemScore += Player.gemScore;
					saveGemScore();
					GemADS.SetActive(false);
					coef = 1;
					}
				break;
		}
		iteration++;
		
			/*if (Player.gemScore > 0)
			{
				if (Advertisement.IsReady("rewardedVideo"))
				{
					Advertisement.Show("rewardedVideo");
					GemScore += Player.gemScore;
					saveGemScore();
					GemADS.SetActive(false);
					coef = 1;
				}
			}
		}*/
     }

    public void Restart()
        {
            SummScore += Player.Score;
            saveScoreSum();

            GemScore += Player.gemScore;
            saveGemScore();

            if (BestScore < Player.Score)
            {
                Player.lose = false;
                SpawnTresh.spead = 1f;

                saveScore();
                BestScore = PlayerPrefs.GetInt(BEST_SCORE);
                Player.Score = 0;
            }
            Invoke("Jopke", 0.2f);
		iteration = 0;
		Player.isPause = false;
		}

    void Jopke()
    {
        Player.lose = false;
        SpawnTresh.spead = 1f;
        Player.Score = 0;
        Player.gemScore = 0;
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }

    public void ToMenu()
    {
        SummScore += Player.Score;
        saveScoreSum();

        GemScore += Player.gemScore;
        saveGemScore();

        Player.lose = false;
        SpawnTresh.spead = 1f;

        if (BestScore < Player.Score)
        {
            saveScore();
            BestScore = PlayerPrefs.GetInt(BEST_SCORE);
        }
        Player.Score = 0;
        Player.gemScore = 0;
        SceneManager.LoadScene("MainMenu");
    }

    void saveScore()
    {
        PlayerPrefs.SetInt(BEST_SCORE, Player.Score);
        PlayerPrefs.Save();
    }

    void saveScoreSum()
    {
        PlayerPrefs.SetInt(SUMM_SCORE, SummScore);
        PlayerPrefs.Save();
    }

    void saveGemScore()
    {
        PlayerPrefs.SetInt(SUMM_GEM_SCORE, GemScore);
        PlayerPrefs.Save();
    }

    public static void init()
    {
        BestScore = PlayerPrefs.GetInt(BEST_SCORE);
        SummScore = PlayerPrefs.GetInt(SUMM_SCORE);
        GemScore = PlayerPrefs.GetInt(SUMM_GEM_SCORE);
    }

}
