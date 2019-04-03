using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class disactive : MonoBehaviour
{
    public Button rainbow_butt;
    public Button catty_butt;

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
            if (PlayerPrefs.GetInt(RestartMenu.SUMM_SCORE) < 1000)
                catty_butt.interactable = false;
        }
        else catty_butt.interactable = true;
    }
}
