using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPrefab : MonoBehaviour
{
    public Sprite LGBT_GG;
    public Sprite Bobel_def;
    public Sprite CattyBobel;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(Custom.CheckLGBT) == 1)
            anim.SetFloat("Rainbow_trans", 1);
            gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;
        if (PlayerPrefs.GetInt(Custom.CheckCatty) == 1)
            anim.SetFloat("Catty_trans", 1);
        gameObject.GetComponent<SpriteRenderer>().sprite = CattyBobel;
        if (PlayerPrefs.GetInt(Custom.CheckBobel) == 1)
            gameObject.GetComponent<SpriteRenderer>().sprite = Bobel_def;
    }

}
