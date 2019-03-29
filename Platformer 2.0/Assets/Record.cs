using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Text Rec;
    //public static float BestScore;
    
    void Update()
    {
       /* if (BestScore > Player.Score)
        {
            PlayerPrefs.SetInt("saveScore", Player.Score);
            PlayerPrefs.Save();
            
        }*/
       
        Rec.text = "" + RestartMenu.BestScore.ToString();
    }
}
