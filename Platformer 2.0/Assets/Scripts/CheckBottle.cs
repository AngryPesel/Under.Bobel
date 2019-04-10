using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBottle : MonoBehaviour
{
    public Sprite Bottle_def;

    private Animator anim_bottle;

    void Start()
    {
        anim_bottle = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(Custom.CheckBottle) == 1)
            gameObject.GetComponent<SpriteRenderer>().sprite = Bottle_def;
        if (PlayerPrefs.GetInt(Custom.CheckBottlePrem) == 1)
            anim_bottle.SetFloat("Bottle_Prem_trans", 1);
    }
}
