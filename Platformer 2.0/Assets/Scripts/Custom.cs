using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Custom : MonoBehaviour
{
    public Sprite LGBT_GG;
    public Sprite Bobel_def;
    public Text pnh; 

    public void LGBT()
    {
        if (RestartMenu.SummScore >= 1000)
            {
            RestartMenu.SummScore = -1000;
            gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;
        }
         else
        {
            pnh.text = ("Poshel nahyi, bomjara");
        }
        
    }

    public void Bobel_Defolt()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Bobel_def;
    }


    
}


