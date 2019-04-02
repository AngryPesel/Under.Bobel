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

    public static string LGBT = "LGBT";
    public static string Catty = "Catty";

    public static int Cond_LGBT = 0;
    public static int Cond_Catty = 0;

    public int Ost;

    public void Buy_LGBT()
    {
        PlayerPrefs.SetInt(LGBT, Cond_LGBT);
        if (PlayerPrefs.GetInt(LGBT, Cond_LGBT) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 1000)
            {
                RestartMenu.SummScore -= 1000;
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 1000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);
                gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;

                Cond_LGBT = 1;
                PlayerPrefs.SetInt(LGBT, Cond_LGBT);
            }
        }
        else gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;
    }


    public void Buy_Catty()
    {
        PlayerPrefs.SetInt(Catty, Cond_Catty);
        if (PlayerPrefs.GetInt(Catty, Cond_Catty) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 5000)
            {
                RestartMenu.SummScore -= 5000;
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 5000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);
                gameObject.GetComponent<SpriteRenderer>().sprite = CattyBobel;

                Cond_Catty = 1;
                PlayerPrefs.SetInt(Catty, Cond_Catty);
            }
        }
        else gameObject.GetComponent<SpriteRenderer>().sprite = CattyBobel;
    }

    public void Select_Bobel_Defolt()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Bobel_def;
    }
  
}


