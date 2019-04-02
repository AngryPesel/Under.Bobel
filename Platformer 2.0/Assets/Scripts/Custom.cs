using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Custom : MonoBehaviour
{
    public Sprite LGBT_GG;
    public Sprite Bobel_def;
    public Sprite CattyBobel;

    public int Ost;

    //public GameObject Shop;

    public void LGBT()
    {
        if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 1000)
        {
            RestartMenu.SummScore -= 1000;
            Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 1000;
            PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);
            gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;
        }
    }

    public void Catty()
    {
        if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 5000)
        {
            RestartMenu.SummScore -= 5000;
            Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 5000;
            PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);
            gameObject.GetComponent<SpriteRenderer>().sprite = CattyBobel;
        }
    }

    public void Bobel_Defolt()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Bobel_def;
    }
  
}


