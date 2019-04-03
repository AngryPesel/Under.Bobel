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

    public static int Cond_LGBT;
    public static int Cond_Catty;

    public static string CheckLGBT = "CheckLGBT";
    public static string CheckCatty = "CheckCatty";
    public static string CheckBobel = "CheckBobel";

    public static int Check_LGBT;
    public static int Check_Catty;
    public static int Check_Bobel;

    public int Ost;

    private void Start()
    {
        Check_LGBT = PlayerPrefs.GetInt(CheckLGBT, Check_LGBT);
        Check_Catty = PlayerPrefs.GetInt(CheckCatty, Check_Catty);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel, Check_Bobel);
    }

    public void Buy_LGBT()
    {
        if (PlayerPrefs.GetInt(LGBT, Cond_LGBT) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 1000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 1000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                Check_LGBT = 1;
                Check_Catty = 0;
                Check_Bobel = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);

                Cond_LGBT = 1;
                PlayerPrefs.SetInt(LGBT, Cond_LGBT);
            }
        }
        else
        {
            Check_LGBT = 1;
            Check_Catty = 0;
            Check_Bobel = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
        }
    }


    public void Buy_Catty()
    {
        if (PlayerPrefs.GetInt(Catty, Cond_Catty) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 5000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 5000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                Check_LGBT = 0;
                Check_Catty = 1;
                Check_Bobel = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);

                Cond_Catty = 1;
                PlayerPrefs.SetInt(Catty, Cond_Catty);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 1;
            Check_Bobel = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
        }
    }

    public void Select_Bobel_Defolt()
    {
        Check_LGBT = 0;
        Check_Catty = 0;
        Check_Bobel = 1;
        PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
        PlayerPrefs.SetInt(CheckCatty, Check_Catty);
        PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
        Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
        Check_Catty = PlayerPrefs.GetInt(CheckCatty);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
    }
  
}


