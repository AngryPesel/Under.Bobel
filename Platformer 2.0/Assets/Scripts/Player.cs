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
    public Text GemScore;

    public static bool CoinIn = false;
    public static bool lose = false;
    public static int Score = 0;
    public static int gemScore = 0;
    public static bool speedUP = false;

    public static int deadscore = 1;

    private Animator anim;
    public Animator CoinUI;

    public AudioClip Tresh;
    public AudioClip Coin;
    public AudioClip CoinEvil;
    public AudioClip ShildActive;
    public AudioClip brocenGlass;

    private void Start()
    {
        ScinesDataBase database = new ScinesDataBase();
        Debug.Log("URA1");
       // database.insertData(new ScinesDataBase.ScineEntity("name", 1, true));
        Debug.Log("URA2");
        database.close();
        Debug.Log("URA3");
        //RestartMenu.coef = 0;
        lose = false;
        CoinIn = false;
        ShildAct = false;
        speedUP = false;

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
                deadscore++;
                restart.SetActive(true);
                pause.SetActive(false);
                GetComponent<AudioSource>().clip = Tresh;
                GetComponent<AudioSource>().Play();
            }
            else
            {
                Destroy(collision.gameObject);
                GetComponent<AudioSource>().clip = brocenGlass;
                GetComponent<AudioSource>().Play();
            }
        }
        if (collision.gameObject.tag == "Coincup")
        {
            anim.SetTrigger("Eat");
            Score += SpawnTresh.det;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.tag == "Coinsilv")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score += SpawnTresh.det + 1;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Coingold")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
            Score += SpawnTresh.det + 2;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Coinevil")
        {
            anim.SetTrigger("Eat");
            GetComponent<AudioSource>().clip = CoinEvil;
            GetComponent<AudioSource>().Play();
            Score -= SpawnTresh.det;
            CoinIn = true;
            Invoke("TimeCoinIn", PauseTime);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Shild")
        {
            GetComponent<AudioSource>().clip = ShildActive;
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            Shild.SetActive(true);
            ShildAct = true;
        }
        if (collision.gameObject.tag == "SpeedUP")
        {
            //AUDIO
            Destroy(collision.gameObject);
            PlayerControl.speed = 1000f;
            speedUP = true;
        }
        if (collision.gameObject.tag == "Gem")
        {
            //Audio
            Destroy(collision.gameObject);
            gemScore++;
        }
    }

   void TimeCoinIn()
    {
        CoinIn = false;
    }
      
    private void Update()
    {
        txt.text = "" + Score;
        //if (RestartMenu.coef == 0)
            GemScore.text = "" + gemScore;
        //else GemScore.text = "" + gemScore * 2;

    }

 


}
