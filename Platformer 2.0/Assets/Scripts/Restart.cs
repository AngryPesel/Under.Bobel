using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   

    
    private void OnMouseDown()
    {
       
        Player.lose = false;
        SpawnTresh.spead = 1f;
        Player.Score = 0;
        SceneManager.LoadScene("Scene1",LoadSceneMode.Single);
    }
}
