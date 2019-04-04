using System.Collections;
using UnityEngine;

public class SpawnTresh : MonoBehaviour
{

    public GameObject tresh;
    public GameObject coincup;
    public GameObject coinsilv;
    public GameObject coingold;
    public GameObject coinevil;

    public static int Score;
    public static float spead = 1.5f;
    public static float intencive = 5;
    public static float intencive2x = 10;

    public float speed1 = 1.5f;
    int n = 30;

    int scr = 0;
    int numm = 20;
    int k = 20;
    public static int det = 1;

    public int Score1 = 10;
    public int Score2 = 20;
    public int Score3 = 30;
  
    void Start()
    {
        StartCoroutine(SpawnTrash());
        StartCoroutine(SpawnCoin());
    }

    IEnumerator SpawnTrash()
    {
        while (!Player.lose)
        {
                Instantiate(tresh, new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
                if (Player.Score >= Score1)
                {
                    spead = speed1 * 1.02f;
                    intencive = 4;
                    intencive2x = 9;
                }
                if (Player.Score >= Score2)
                {
                    spead = speed1;
                    intencive = 3;
                    intencive2x = 8;
                    
                }
                if (Player.Score >= Score3)
                {
                    spead = speed1 * 1.05f;
                    intencive = 2;
                    intencive2x = 7;
                    speed1 = spead;
                    n += 10;
                    Score1 = Score1 + n;
                    n += 10;
                    Score2 = Score2 + n;
                    n += 10;
                    Score3 = Score3 + n;
                }

            yield return new WaitForSeconds(spead);
        }

    }
    IEnumerator SpawnCoin()
    {
        while (!Player.lose)
        {
            float i= Random.Range(0f, 1f);
            //print("random "+i);
            if (i > 0.5)
            {               
                if (Player.Score >= scr)
                    Instantiate(coincup, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score >= (scr + numm))
                    Instantiate(coinsilv, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score >= (scr+2*numm))
                    Instantiate(coingold, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score >= (scr+3*numm))
                    Instantiate(coinevil, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score == (scr + 4 * numm + 20))
                {
                    scr += 5 * numm;
                    numm += 20;
                    det += 1;
                }
            }
            else
            {
                if (Player.Score >= scr)
                    Instantiate(coincup, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score >= (scr + numm))
                    Instantiate(coinsilv, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score >= (scr + 2 * numm))
                    Instantiate(coingold, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score >= (scr + 3 * numm))
                    Instantiate(coinevil, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                if (Player.Score == (scr + 4 * numm + 20))
                {
                    scr += 5 * numm;
                    numm += 20;
                    det += 1;
                }
            }
            /*if (Player.Score >= 20)
            {
                Instantiate(coin2x, new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
                Instantiate(coin, new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            }*/
            yield return new WaitForSeconds(Random.Range(1f, intencive));  
        }

        /*while (!Player.lose)
        {
            
          
            if (Player.Score >= 1)
            {
                Instantiate(coin2x, new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            }
           
            yield return new WaitForSeconds(Random.Range(1f, intencive2x));
        }*/
    }
}
