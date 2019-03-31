using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public GameObject restart;
    public float PauseTime;
    public Text txt;
    public static bool CoinIn = false;
    public static bool lose = false;
    public static int Score = 0;
    public GameObject coin;
    private Animator anim;
        private bool Dead = false;
    public Animator CoinUI;


  

    public AudioClip Tresh;
    public AudioClip Coin;
   

    private void Start()
    {
        lose = false;
        CoinIn = false;
        anim = GetComponent<Animator>();
        CoinUI = GetComponent<Animator>();
    }

    

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tresh")
        {
            anim.SetBool("Dead", true);
            lose = true;
            restart.SetActive(true);
            GetComponent<AudioSource>().clip = Tresh;
            GetComponent<AudioSource>().Play();
        }
        else if (collision.gameObject.tag == "Coin")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score++;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag == "Coin2X")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score+=2;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        //anim.ResetTrigger("Eat");
        // CoinIn = false;
    }

   void TimeCoinIn()
    {
        CoinIn = false;
    }
    
   

    
private void Update()
    {
        txt.text = "" + Score;
    }

 


}
