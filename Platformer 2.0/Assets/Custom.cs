using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom : MonoBehaviour
{
    public Sprite LGBT_GG;

    public void LGBT()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = LGBT_GG;
        
    }


}
