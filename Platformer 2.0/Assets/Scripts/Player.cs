using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public GameObject restart;
    public GameObject pause;
    public GameObject Shild;

    public static bool ShildAct = false;

    public float PauseTime;
    public Text txt;
    public static bool CoinIn = false;
    public static bool lose = false;
    public static int Score = 0;

    private Animator anim;
    public Animator CoinUI;

    public AudioClip Tresh;
    public AudioClip Coin;

    private void Start()
    {
        lose = false;
        CoinIn = false;
        ShildAct = false;
        anim = GetComponent<Animator>();
        CoinUI = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tresh")
        {
            if (!ShildAct)
            {
                anim.SetBool("Dead", true);
                lose = true;
                restart.SetActive(true);
                pause.SetActive(false);
                GetComponent<AudioSource>().clip = Tresh;
                GetComponent<AudioSource>().Play();
            }
            else
            {
                Destroy(collision.gameObject);                    
            };
        }
        else if (collision.gameObject.tag == "Coincup")
        {
            anim.SetTrigger("Eat");
            Score += SpawnTresh.det;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
        }
        else if (collision.gameObject.tag == "Coinsilv")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score += SpawnTresh.det + 1;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Coingold")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score += SpawnTresh.det + 2;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Coinevil")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score -= SpawnTresh.det;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Shild")
        {
            //Audio
            Destroy(collision.gameObject);
            Shild.SetActive(true);
            ShildAct = true;
        }
    }

   void TimeCoinIn()
    {
        CoinIn = false;
    }
      
    private void Update()
    {
        txt.text = "" + Score;
        Debug.Log(ShildAct);
    }

 


}
