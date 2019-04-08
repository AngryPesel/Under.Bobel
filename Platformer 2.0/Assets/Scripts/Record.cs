using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Text Rec;
    public Text Summ;
    public Text Gem;
    
    void Update()
    {
        RestartMenu.init();
        Rec.text = "" + RestartMenu.BestScore.ToString();
        Summ.text = "" + RestartMenu.SummScore.ToString();
        Gem.text = "" + RestartMenu.GemScore.ToString();
    }
}
