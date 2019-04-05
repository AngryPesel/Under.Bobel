using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShildScript : MonoBehaviour
{
    public GameObject Shild;

    float timeShild = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        timeShild -= Time.deltaTime;
        if (timeShild <= 0)
        {
            Shild.SetActive(false);
            Player.ShildAct = false;
            timeShild = 5f;
        }
    }
}
