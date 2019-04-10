using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Custom : MonoBehaviour
{
    public static string LGBT = "LGBT";
    public static string Catty = "Catty";
    public static string Orange = "Orange";
    public static string Candy = "Candy";
    public static string Dog = "Dog";

    public static int Cond_LGBT;
    public static int Cond_Catty;
    public static int Cond_Orange;
    public static int Cond_Candy;
    public static int Cond_Dog;

    public static string CheckLGBT = "CheckLGBT";
    public static string CheckCatty = "CheckCatty";
    public static string CheckBobel = "CheckBobel";
    public static string CheckOrange = "CheckOrange";
    public static string CheckCandy = "CheckCandy";
    public static string CheckDog = "CheckDog";

    public static int Check_LGBT;
    public static int Check_Catty;
    public static int Check_Bobel;
    public static int Check_Orange;
    public static int Check_Candy;
    public static int Check_Dog;

    public int Ost;

    private void Start()
    {
        Check_LGBT = PlayerPrefs.GetInt(CheckLGBT, Check_LGBT);
        Check_Catty = PlayerPrefs.GetInt(CheckCatty, Check_Catty);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel, Check_Bobel);
        Check_Orange = PlayerPrefs.GetInt(CheckOrange, Check_Orange);
        Check_Candy = PlayerPrefs.GetInt(CheckCandy, Check_Candy);
        Check_Dog = PlayerPrefs.GetInt(CheckDog, Check_Dog);
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
                Check_Orange = 0;
                Check_Candy = 0;
                Check_Dog = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);

                Cond_LGBT = 1;
                PlayerPrefs.SetInt(LGBT, Cond_LGBT);
            }
        }
        else
        {
            Check_LGBT = 1;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 0;
            Check_Dog = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
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
                Check_Orange = 0;
                Check_Candy = 0;
                Check_Dog = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);

                Cond_Catty = 1;
                PlayerPrefs.SetInt(Catty, Cond_Catty);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 1;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 0;
            Check_Dog = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
        }
    }

    public void Buy_Orange()
    {
        if (PlayerPrefs.GetInt(Orange, Cond_Orange) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 10000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 10000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                Check_LGBT = 0;
                Check_Catty = 0;
                Check_Bobel = 0;
                Check_Orange = 1;
                Check_Candy = 0;
                Check_Dog = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);

                Cond_Orange = 1;
                PlayerPrefs.SetInt(Orange, Cond_Orange);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 1;
            Check_Candy = 0;
            Check_Dog = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
        }
    }

    public void Buy_Candy()
    {
        if (PlayerPrefs.GetInt(Candy, Cond_Candy) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 20000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 20000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                Check_LGBT = 0;
                Check_Catty = 0;
                Check_Bobel = 0;
                Check_Orange = 0;
                Check_Candy = 1;
                Check_Dog = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);

                Cond_Candy = 1;
                PlayerPrefs.SetInt(Candy, Cond_Candy);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 1;
            Check_Dog = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
        }
    }

    public void Buy_Dog()
    {
        if (PlayerPrefs.GetInt(Dog, Cond_Dog) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 27000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 27000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                Check_LGBT = 0;
                Check_Catty = 0;
                Check_Bobel = 0;
                Check_Orange = 0;
                Check_Candy = 0;
                Check_Dog = 1;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);

                Cond_Dog = 1;
                PlayerPrefs.SetInt(Dog, Cond_Dog);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 0;
            Check_Dog = 1;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
        }
    }

    public void Select_Bobel_Defolt()
    {
        Check_LGBT = 0;
        Check_Catty = 0;
        Check_Bobel = 1;
        Check_Orange = 0;
        Check_Candy = 0;
        Check_Dog = 0;
        PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
        PlayerPrefs.SetInt(CheckCatty, Check_Catty);
        PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
        PlayerPrefs.SetInt(CheckOrange, Check_Orange);
        PlayerPrefs.SetInt(CheckCandy, Check_Candy);
        PlayerPrefs.SetInt(CheckDog, Check_Dog);
        Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
        Check_Catty = PlayerPrefs.GetInt(CheckCatty);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
        Check_Orange = PlayerPrefs.GetInt(CheckOrange);
        Check_Candy = PlayerPrefs.GetInt(CheckCandy);
        Check_Dog = PlayerPrefs.GetInt(CheckDog);
    }
  
}


