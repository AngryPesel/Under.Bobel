using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public static float BestScore;
    public void Restart()
    {
        if (BestScore < Player.Score)
        {
            Player.lose = false;
            SpawnTresh.spead = 1f;
            
            PlayerPrefs.SetInt("saveScore", Player.Score);
            //PlayerPrefs.Save();
            BestScore = PlayerPrefs.GetInt("saveScore");
            Player.Score = 0;
        }
        Invoke("Jopke", 0.2f);

        
    }

    void Jopke()
    {
        Player.lose = false;
        SpawnTresh.spead = 1f;
        Player.Score = 0;
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }

    public void ToMenu()
    {
        Player.lose = false;
        SpawnTresh.spead = 1f;
        
        if (BestScore < Player.Score)
        {

            PlayerPrefs.SetInt("saveScore", Player.Score);
            //PlayerPrefs.Save();
            BestScore = PlayerPrefs.GetInt("saveScore");
        }
        SceneManager.LoadScene("MainMenu");
        Player.Score = 0;
    }
}
