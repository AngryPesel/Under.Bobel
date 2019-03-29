using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour

{
    private void OnMouseDown()
    {
        Player.Score = 0;
        SceneManager.LoadScene("MainMenu");
    }
}

