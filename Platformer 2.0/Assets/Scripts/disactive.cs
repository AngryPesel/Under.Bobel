using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class disactive : MonoBehaviour
{
    public Sprite BuyButton;
    public Sprite SelectButton;

    public GameObject OrangeButt;
    public GameObject RainbowButt;
    public GameObject CandyButt;
    public GameObject CattyButt;
    public GameObject DogButt;
    public GameObject UnicButt;
    public GameObject DiverButt;

    public GameObject BottlePremButt;

    public Button rainbow_butt;
    public Button catty_butt;
    public Button orange_butt;
    public Button candy_butt;
    public Button dog_butt;
    public Button unic_butt;
    public Button diver_butt;


    public Button bottle_prem_butt;

    void Update()
    {
        if (PlayerPrefs.GetInt(Custom.LGBT) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 5000)
            {
                rainbow_butt.interactable = false;
                RainbowButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            rainbow_butt.interactable = true;
            RainbowButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Catty) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 20000)
            {
                catty_butt.interactable = false;
                CattyButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            catty_butt.interactable = true;
            CattyButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Orange) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 1000)
            {
                orange_butt.interactable = false;
                OrangeButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            orange_butt.interactable = true;
            OrangeButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Candy) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 10000)
            {
                candy_butt.interactable = false;
                CandyButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            candy_butt.interactable = true;
            CandyButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Dog) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 30000)
            {
                dog_butt.interactable = false;
                DogButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            dog_butt.interactable = true;
            DogButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Bottle_Prem) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) < 50)
            {
                bottle_prem_butt.interactable = false;
                BottlePremButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            bottle_prem_butt.interactable = true;
            BottlePremButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Unic) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) < 150)
            {
                unic_butt.interactable = false;
                UnicButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            unic_butt.interactable = true;
            UnicButt.GetComponent<Image>().sprite = SelectButton;
        }

        if (PlayerPrefs.GetInt(Custom.Bottle_Prem) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) < 300)
            {
                diver_butt.interactable = false;
                DiverButt.GetComponent<Image>().sprite = BuyButton;
            }
        }
        else
        {
            diver_butt.interactable = true;
            DiverButt.GetComponent<Image>().sprite = SelectButton;
        }
    }
}
