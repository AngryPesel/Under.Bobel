using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Shop;

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
}
