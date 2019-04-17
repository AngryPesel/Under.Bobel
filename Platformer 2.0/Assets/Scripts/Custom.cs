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

    public GameObject SelectBobel;
    public GameObject SelectOrange;
    public GameObject SelectRainbow;
    public GameObject SelectCandy;
    public GameObject SelectCat;
    public GameObject SelectDog;
    public GameObject SelectUnic;
    public GameObject SelectDiver;

    public GameObject SelectBottleDef;
    public GameObject SelectBottlePem;

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

        if (Check_LGBT == 1)
            SelectRainbow.SetActive(true);
        if (Check_Bobel == 1)
            SelectBobel.SetActive(true);
        if (Check_Orange == 1)
            SelectOrange.SetActive(true);
        if (Check_Catty == 1)
            SelectCat.SetActive(true);
        if (Check_Candy == 1)
            SelectCandy.SetActive(true);
        if (Check_Dog == 1)
            SelectDog.SetActive(true);
        if (Check_Unic == 1)
            SelectUnic.SetActive(true);
        if (Check_Diver == 1)
            SelectDiver.SetActive(true);

        if (Check_Bottle_Prem == 1)
            SelectBottlePem.SetActive(true);
        if (Check_Bottle == 1)
            SelectBottleDef.SetActive(true);
    }

    public void Buy_LGBT()
    {
        if (PlayerPrefs.GetInt(LGBT, Cond_LGBT) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 5000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 5000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                CheckBobelMet();
                Check_LGBT = 1;               
                PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
                Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);

                Cond_LGBT = 1;
                PlayerPrefs.SetInt(LGBT, Cond_LGBT);

                CheckSceen();
                SelectRainbow.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_LGBT = 1;
            PlayerPrefs.SetInt(CheckLGBT, Check_LGBT);
            Check_LGBT = PlayerPrefs.GetInt(CheckLGBT);

            CheckSceen();
            SelectRainbow.SetActive(true);
        }
    }


    public void Buy_Catty()
    {
        if (PlayerPrefs.GetInt(Catty, Cond_Catty) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 20000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 20000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                CheckBobelMet();
                Check_Catty = 1;
                PlayerPrefs.SetInt(CheckCatty, Check_Catty);
                Check_Catty = PlayerPrefs.GetInt(CheckCatty);

                Cond_Catty = 1;
                PlayerPrefs.SetInt(Catty, Cond_Catty);

                CheckSceen();
                SelectCat.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_Catty = 1;
            PlayerPrefs.SetInt(CheckCatty, Check_Catty);
            Check_Catty = PlayerPrefs.GetInt(CheckCatty);

            CheckSceen();
            SelectCat.SetActive(true);
        }
    }

    public void Buy_Orange()
    {
        if (PlayerPrefs.GetInt(Orange, Cond_Orange) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 1000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 1000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                CheckBobelMet();
                Check_Orange = 1;
                PlayerPrefs.SetInt(CheckOrange, Check_Orange);
                Check_Orange = PlayerPrefs.GetInt(CheckOrange);

                Cond_Orange = 1;
                PlayerPrefs.SetInt(Orange, Cond_Orange);

                CheckSceen();
                SelectOrange.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_Orange = 1;
            PlayerPrefs.SetInt(CheckOrange, Check_Orange);
            Check_Orange = PlayerPrefs.GetInt(CheckOrange);

            CheckSceen();
            SelectOrange.SetActive(true);
        }
    }

    public void Buy_Candy()
    {
        if (PlayerPrefs.GetInt(Candy, Cond_Candy) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 10000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 10000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                CheckBobelMet();
                Check_Candy = 1;               
                PlayerPrefs.SetInt(CheckCandy, Check_Candy);               
                Check_Candy = PlayerPrefs.GetInt(CheckCandy);

                Cond_Candy = 1;
                PlayerPrefs.SetInt(Candy, Cond_Candy);

                CheckSceen();
                SelectCandy.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_Candy = 1;
            PlayerPrefs.SetInt(CheckCandy, Check_Candy);
            Check_Candy = PlayerPrefs.GetInt(CheckCandy);

            CheckSceen();
            SelectCandy.SetActive(true);
        }
    }

    public void Buy_Dog()
    {
        if (PlayerPrefs.GetInt(Dog, Cond_Dog) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) >= 30000)
            {
                Ost = PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) - 30000;
                PlayerPrefs.SetInt(RestartMenu.SUMM_SCORE, Ost);

                CheckBobelMet();
                Check_Dog = 1;               
                PlayerPrefs.SetInt(CheckDog, Check_Dog);                
                Check_Dog = PlayerPrefs.GetInt(CheckDog);

                Cond_Dog = 1;
                PlayerPrefs.SetInt(Dog, Cond_Dog);

                CheckSceen();
                SelectCandy.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_Dog = 1;
            PlayerPrefs.SetInt(CheckDog, Check_Dog);
            Check_Dog = PlayerPrefs.GetInt(CheckDog);

            CheckSceen();
            SelectCandy.SetActive(true);
        }
    }

    public void Buy_Unic()
    {
        if (PlayerPrefs.GetInt(Unic, Cond_Unic) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) >= 150)
            {
                Ost_Gem = PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) - 150;
                PlayerPrefs.SetInt(RestartMenu.SUMM_GEM_SCORE, Ost_Gem);

                CheckBobelMet();
                Check_Unic = 1;               
                PlayerPrefs.SetInt(CheckUnic, Check_Unic);               
                Check_Unic = PlayerPrefs.GetInt(CheckUnic);

                Cond_Unic = 1;
                PlayerPrefs.SetInt(Unic, Cond_Unic);

                CheckSceen();
                SelectUnic.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_Unic = 1;
            PlayerPrefs.SetInt(CheckUnic, Check_Unic);
            Check_Unic = PlayerPrefs.GetInt(CheckUnic);

            CheckSceen();
            SelectUnic.SetActive(true);
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

                CheckBobelMet();
                Check_Diver = 1;               
                PlayerPrefs.SetInt(CheckDiver, Check_Diver);
                Check_Diver = PlayerPrefs.GetInt(CheckDiver);

                Cond_Diver = 1;
                PlayerPrefs.SetInt(Diver, Cond_Diver);

                CheckSceen();
                SelectDiver.SetActive(true);
            }
        }
        else
        {
            CheckBobelMet();
            Check_Diver = 1;
            PlayerPrefs.SetInt(CheckDiver, Check_Diver);
            Check_Diver = PlayerPrefs.GetInt(CheckDiver);

            CheckSceen();
            SelectDiver.SetActive(true);
        }
    }

    public void Select_Bobel_Defolt()
    {
        CheckBobelMet();
        Check_Bobel = 1;
        PlayerPrefs.SetInt(CheckBobel, Check_Bobel);
        Check_Bobel = PlayerPrefs.GetInt(CheckBobel);

        CheckSceen();
        SelectBobel.SetActive(true);
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

                CheckBottleSceen();
                SelectBottlePem.SetActive(true);
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

            CheckBottleSceen();
            SelectBottlePem.SetActive(true);
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

        CheckBottleSceen();
        SelectBottleDef.SetActive(true);
    }

    void CheckBobelMet()
    {
        Check_LGBT = 0;
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

    void CheckSceen()
    {
        SelectRainbow.SetActive(false);
        SelectBobel.SetActive(false);
        SelectOrange.SetActive(false);
        SelectCat.SetActive(false);
        SelectCandy.SetActive(false);
        SelectDog.SetActive(false);
        SelectUnic.SetActive(false);
        SelectDiver.SetActive(false);
    }

    void CheckBottleSceen()
    {
        SelectBottlePem.SetActive(false);
        SelectBottleDef.SetActive(false);
    }
}


