using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public GameObject restart;
    public GameObject pause;
    public GameObject Shild;
    public GameObject ScoreCalcGO;

    public static bool ShildAct = false;

    public float PauseTime;
    public Text txt;
    public Text GemScore;
    public Text ScoreCalc;

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
    public AudioClip Magic;
    public AudioClip SpeadUp;

	public static int iteration;
	public static bool isPause;

    private float timeDisappers = 0.5f;
    private float time = 0;

    private void Start()
    {
        RestartMenu.coef = 0;
        lose = false;
        CoinIn = false;
        ShildAct = false;
        speedUP = false;

        anim = GetComponent<Animator>();
        CoinUI = GetComponent<Animator>();
        iteration = 0;
        isPause = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tresh")
        {
            if (!ShildAct)
            {
				pause.SetActive(false);
				isPause = true;
				if (iteration == 0)
				{
					iteration++;
					Destroy(collision.gameObject);
					restart.SetActive(true);
                    Time.timeScale = 0;
				}
				else
				{
					anim.SetBool("Dead", true);
					lose = true;
					deadscore++;
					restart.SetActive(true);
					GetComponent<AudioSource>().clip = Tresh;
					GetComponent<AudioSource>().Play();
					iteration = 0;
				}
			}
            else
            {
                Destroy(collision.gameObject);
                GetComponent<AudioSource>().clip = brocenGlass;
                GetComponent<AudioSource>().Play();
                Shild.SetActive(false);
                ShildAct = false;
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
            ScoreCalcGO.SetActive(true);
            time = timeDisappers;
            ScoreCalc.text = "+" + SpawnTresh.det;
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
            ScoreCalcGO.SetActive(true);
            time = timeDisappers;
            ScoreCalc.text = "+" + (SpawnTresh.det+1);
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
            ScoreCalcGO.SetActive(true);
            time = timeDisappers;
            ScoreCalc.text = "+" + (SpawnTresh.det+2);
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
            ScoreCalcGO.SetActive(true);
            time = timeDisappers;
            ScoreCalc.text = "-" +(SpawnTresh.det * (-1));
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
            GetComponent<AudioSource>().clip = SpeadUp;
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            PlayerControl.speed = 1000f;
            speedUP = true;
        }
        if (collision.gameObject.tag == "Gem")
        {
            GetComponent<AudioSource>().clip = Magic;
            GetComponent<AudioSource>().Play();
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
        if (RestartMenu.coef == 0)
            GemScore.text = "" + gemScore;
        else GemScore.text = "" + gemScore * 2;
		if (!isPause)
		{
			Time.timeScale = 1;
			restart.SetActive(false);
			pause.SetActive(true);
		}
        if (time <= 0)
        {
            ScoreCalcGO.SetActive(false);
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

}
