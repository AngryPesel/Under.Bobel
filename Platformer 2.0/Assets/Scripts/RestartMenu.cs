using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public static int BestScore;
    public static int SummScore;
    public static int GemScore;

    public static string BEST_SCORE = "saveScore";
    public static string SUMM_SCORE = "ScoreSumm";
    public static string SUMM_GEM_SCORE = "GemScore";

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
        //Player.Score = 0;
        //Player.gemScore = 0;
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
