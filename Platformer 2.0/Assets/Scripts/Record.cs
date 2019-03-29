using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Text Rec;
    public Text Summ;
    
    void Update()
    {  
        Rec.text = "" + RestartMenu.BestScore.ToString();
        Summ.text = "" + RestartMenu.SummScore.ToString();
    }
}
