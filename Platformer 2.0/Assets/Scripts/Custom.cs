using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Custom : MonoBehaviour
{
    public Sprite LGBT_GG;
    public Sprite Bobel_def;
    public Sprite CattyBobel;

    public GameObject Shop;

    public void LGBT()
    {
       
            RestartMenu.SummScore = -1000;
            gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;
            Shop.SetActive(false);
    }

    public void Catty()
    {
       
            RestartMenu.SummScore = -5000;
            gameObject.GetComponent<SpriteRenderer>().sprite = CattyBobel;
            Shop.SetActive(false);
    }
    public void Bobel_Defolt()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Bobel_def;
        Shop.SetActive(false);
    }
  
}


