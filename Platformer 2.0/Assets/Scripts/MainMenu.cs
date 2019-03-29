﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Player.lose = false;
        SceneManager.LoadScene("Scene1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
