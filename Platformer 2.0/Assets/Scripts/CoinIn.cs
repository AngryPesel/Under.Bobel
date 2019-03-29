﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinIn : MonoBehaviour
{
    private Animator coin;


    private void Start()
    {
        coin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.CoinIn == true)
        {
            coin.SetTrigger("CoinIn");
        
        }

              
    }
}
