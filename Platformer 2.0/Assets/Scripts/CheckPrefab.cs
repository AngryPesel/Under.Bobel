using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPrefab : MonoBehaviour
{
    public Sprite Bobel_def;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(Custom.CheckLGBT) == 1)
            anim.SetFloat("Rainbow_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckCatty) == 1)
            anim.SetFloat("Catty_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckBobel) == 1)
            gameObject.GetComponent<SpriteRenderer>().sprite = Bobel_def;
        if (PlayerPrefs.GetInt(Custom.CheckOrange) == 1)
            anim.SetFloat("Orange_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckCandy) == 1)
            anim.SetFloat("Candy_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckDog) == 1)
            anim.SetFloat("Dog_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckUnic) == 1)
            anim.SetFloat("Unic_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckPirate) == 1)
            anim.SetFloat("Pirate_trans", 1);
        if (PlayerPrefs.GetInt(Custom.CheckDiver) == 1)
            anim.SetFloat("Diver_trans", 1);
    }

}
