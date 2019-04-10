using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class disactive : MonoBehaviour
{
    public Button rainbow_butt;
    public Button catty_butt;
    public Button orange_butt;
    public Button candy_butt;
    public Button dog_butt;

    public Button bottle_prem_butt;

    void Update()
    {
        if (PlayerPrefs.GetInt(Custom.LGBT) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 1000)
                rainbow_butt.interactable = false;
        }
        else rainbow_butt.interactable = true;

        if (PlayerPrefs.GetInt(Custom.Catty) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 5000)
                catty_butt.interactable = false;
        }
        else catty_butt.interactable = true;

        if (PlayerPrefs.GetInt(Custom.Orange) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 10000)
                orange_butt.interactable = false;
        }
        else orange_butt.interactable = true;

        if (PlayerPrefs.GetInt(Custom.Candy) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 20000)
                candy_butt.interactable = false;
        }
        else candy_butt.interactable = true;

        if (PlayerPrefs.GetInt(Custom.Dog) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 27000)
                dog_butt.interactable = false;
        }
        else dog_butt.interactable = true;

        if (PlayerPrefs.GetInt(Custom.Bottle_Prem) < 1)
        {
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_GEM_SCORE) < 50)
                bottle_prem_butt.interactable = false;
        }
        else bottle_prem_butt.interactable = true;
    }
}
