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
    public static string Unic = "Unic";
    public static string Pirate = "Pirate";
    public static string Diver = "Diver";

    public static string Bottle = "Bottle";
    public static string Bottle_Prem = "Bottle_Prem";

    public static int Cond_LGBT;
    public static int Cond_Catty;
    public static int Cond_Orange;
    public static int Cond_Candy;
    public static int Cond_Dog;
    public static int Cond_Unic;
    public static int Cond_Pirate;
    public static int Cond_Diver;

    public static int Cond_Bottle;
    public static int Cond_Bottle_Prem;

    public static string CheckLGBT = "CheckLGBT";
    public static string CheckCatty = "CheckCatty";
    public static string CheckBobel = "CheckBobel";
    public static string CheckOrange = "CheckOrange";
    public static string CheckCandy = "CheckCandy";
    public static string CheckDog = "CheckDog";
    public static string CheckUnic = "CheckUnic";
    public static string CheckPirate = "CheckPirate";
    public static string CheckDiver = "CheckDiver";

    public static string CheckBottle = "CheckBottle";
    public static string CheckBottlePrem = "CheckBottlePrem";

    public static int Check_LGBT;
    public static int Check_Catty;
    public static int Check_Bobel;
    public static int Check_Orange;
    public static int Check_Candy;
    public static int Check_Dog;
    public static int Check_Unic;
    public static int Check_Pirate;
    public static int Check_Diver;

    public static int Check_Bottle;
    public static int Check_Bottle_Prem;

    public int Ost;
    public int Ost_Gem;

    private void Start()
    {
        Check_LGBT = PlayerPrefs.GetInt(CheckLGBT, Check_LGBT);
        Check_Catty = PlayerPrefs.GetInt(CheckCatty, Check_Catty);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel, Check_Bobel);
        Check_Orange = PlayerPrefs.GetInt(CheckOrange, Check_Orange);
        Check_Candy = PlayerPrefs.GetInt(CheckCandy, Check_Candy);
        Check_Dog = PlayerPrefs.GetInt(CheckDog, Check_Dog);
        Check_Unic = PlayerPrefs.GetInt(CheckUnic, Check_Unic);
        Check_Pirate = PlayerPrefs.GetInt(CheckPirate, Check_Pirate);
        Check_Diver = PlayerPrefs.GetInt(CheckDiver, Check_Diver);

        Check_Bottle = PlayerPrefs.GetInt(CheckBottle, Check_Bottle);
        Check_Bottle_Prem = PlayerPrefs.GetInt(CheckBottlePrem, Check_Bottle_Prem);
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
                Check_Unic = 0;
                Check_Pirate = 0;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

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
            Check_Unic = 0;
            Check_Pirate = 0;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
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
                Check_Unic = 0;
                Check_Pirate = 0;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

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
            Check_Unic = 0;
            Check_Pirate = 0;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
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
                Check_Unic = 0;
                Check_Pirate = 0;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

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
            Check_Unic = 0;
            Check_Pirate = 0;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
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
                Check_Unic = 0;
                Check_Pirate = 0;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

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
            Check_Unic = 0;
            Check_Pirate = 0;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
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
                Check_Unic = 0;
                Check_Pirate = 0;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

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
            Check_Unic = 0;
            Check_Pirate = 0;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
        }
    }

    public void Buy_Unic()
    {
        if (PlayerPrefs.GetInt(Unic, Cond_Unic) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) >= 100)
            {
                Ost_Gem = PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) - 100;
                PlayerPrefs.SetInt(RestartMenu.SUMM_GEM_SCORE, Ost_Gem);

                Check_LGBT = 0;
                Check_Catty = 0;
                Check_Bobel = 0;
                Check_Orange = 0;
                Check_Candy = 0;
                Check_Dog = 0;
                Check_Unic = 1;
                Check_Pirate = 0;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

                Cond_Unic = 1;
                PlayerPrefs.SetInt(Unic, Cond_Unic);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 0;
            Check_Dog = 0;
            Check_Unic = 1;
            Check_Pirate = 0;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
        }
    }

    public void Buy_Pirate()
    {
        if (PlayerPrefs.GetInt(Pirate, Cond_Pirate) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) >= 200)
            {
                Ost_Gem = PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) - 200;
                PlayerPrefs.SetInt(RestartMenu.SUMM_GEM_SCORE, Ost_Gem);

                Check_LGBT = 0;
                Check_Catty = 0;
                Check_Bobel = 0;
                Check_Orange = 0;
                Check_Candy = 0;
                Check_Dog = 0;
                Check_Unic = 0;
                Check_Pirate = 1;
                Check_Diver = 0;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

                Cond_Pirate = 1;
                PlayerPrefs.SetInt(Pirate, Cond_Pirate);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 0;
            Check_Dog = 0;
            Check_Unic = 0;
            Check_Pirate = 1;
            Check_Diver = 0;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
        }
    }

    public void Buy_Diver()
    {
        if (PlayerPrefs.GetInt(Diver, Cond_Diver) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) >= 300)
            {
                Ost_Gem = PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) - 300;
                PlayerPrefs.SetInt(RestartMenu.SUMM_GEM_SCORE, Ost_Gem);

                Check_LGBT = 0;
                Check_Catty = 0;
                Check_Bobel = 0;
                Check_Orange = 0;
                Check_Candy = 0;
                Check_Dog = 0;
                Check_Unic = 0;
                Check_Pirate = 0;
                Check_Diver = 1;
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);
                PlayerPrefs.SetInt(CheckDog, Check_Dog);
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);
                PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);
                Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);
                Check_Dog = PlayerPrefs.GetInt(CheckDog);
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);
                Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

                Cond_Diver = 1;
                PlayerPrefs.SetInt(Diver, Cond_Diver);
            }
        }
        else
        {
            Check_LGBT = 0;
            Check_Catty = 0;
            Check_Bobel = 0;
            Check_Orange = 0;
            Check_Candy = 0;
            Check_Dog = 0;
            Check_Unic = 0;
            Check_Pirate = 0;
            Check_Diver = 1;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);
            Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);
            Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);
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
        Check_Unic = 0;
        Check_Pirate = 0;
        Check_Diver = 0;
        PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
        PlayerPrefs.SetInt(CheckCatty, Check_Catty);
        PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
        PlayerPrefs.SetInt(CheckOrange, Check_Orange);
        PlayerPrefs.SetInt(CheckCandy, Check_Candy);
        PlayerPrefs.SetInt(CheckDog, Check_Dog);
        PlayerPrefs.SetInt(CheckUnic, Check_Unic);
        PlayerPrefs.SetInt(CheckPirate, Check_Pirate);
        PlayerPrefs.SetInt(CheckDiver, Check_Diver);
        Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);
        Check_Catty = PlayerPrefs.GetInt(CheckCatty);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel);
        Check_Orange = PlayerPrefs.GetInt(CheckOrange);
        Check_Candy = PlayerPrefs.GetInt(CheckCandy);
        Check_Dog = PlayerPrefs.GetInt(CheckDog);
        Check_Unic = PlayerPrefs.GetInt(CheckUnic);
        Check_Pirate = PlayerPrefs.GetInt(CheckPirate);
        Check_Diver = PlayerPrefs.GetInt(CheckDiver);
    }
  
    public void Buy_Bottle_Prem()
    {
        if (PlayerPrefs.GetInt(Bottle_Prem, Cond_Bottle_Prem) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) >= 50)
            {
                Ost_Gem = PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) - 50;
                PlayerPrefs.SetInt(RestartMenu.SUMM_GEM_SCORE, Ost_Gem);

                Check_Bottle = 0;
                Check_Bottle_Prem = 1;
                PlayerPrefs.SetInt(CheckBottle, Check_Bottle);
                PlayerPrefs.SetInt(CheckBottlePrem, Check_Bottle_Prem);
                Check_Bottle = PlayerPrefs.GetInt(CheckBottle);
                Check_Bottle_Prem = PlayerPrefs.GetInt(CheckBottlePrem);

                Cond_Bottle_Prem = 1;
                PlayerPrefs.SetInt(Bottle_Prem, Cond_Bottle_Prem);
            }
        }
        else
        {
            Check_Bottle = 0;
            Check_Bottle_Prem = 1;
            PlayerPrefs.SetInt(CheckBottle, Check_Bottle);
            PlayerPrefs.SetInt(CheckBottlePrem, Check_Bottle_Prem);
            Check_Bottle = PlayerPrefs.GetInt(CheckBottle);
            Check_Bottle_Prem = PlayerPrefs.GetInt(CheckBottlePrem);
        }
    }

    public void Select_Bottle_Def()
    {
        Check_Bottle = 1;
        Check_Bottle_Prem = 0;
        PlayerPrefs.SetInt(CheckBottle, Check_Bottle);
        PlayerPrefs.SetInt(CheckBottlePrem, Check_Bottle_Prem);
        Check_Bottle = PlayerPrefs.GetInt(CheckBottle);
        Check_Bottle_Prem = PlayerPrefs.GetInt(CheckBottlePrem);
    }
}


