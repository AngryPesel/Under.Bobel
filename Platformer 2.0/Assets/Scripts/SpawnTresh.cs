using System.Collections;
using UnityEngine;

public class SpawnTresh : MonoBehaviour
{
    private float SpawnCup = 0.0f;
    private float SpawnSilv = 0.0f;
    private float SpawnGold = 0.0f;
    private float SpawnEvil = 0.0f;

    public GameObject tresh;
    public GameObject coincup;
    public GameObject coinsilv;
    public GameObject coingold;
    public GameObject coinevil;

    public static int Score;
    public static float spead = 1.5f;
    public static float intenciveCup = 5f;
    public static float intenciveSilv = 7f;
    public static float intenciveGold = 9f;
    public static float intenciveEvil = 5f;

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
        int scr = 0;
        int numm = 20;
        int k = 20;

        StartCoroutine(SpawnTrash());
        StartCoroutine(SpawnCoinCUP());
    }

    private void Update()
    {
        while (!Player.lose)
        {
            StopAllCoroutines();
        }
            if (Player.Score >= (scr + numm))
                if (Time.time > SpawnSilv)
                {
                    int i = Random.Range(1, 4);
                    if (i == 1)
                        Instantiate(coinsilv, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                    else if (i == 2)
                        Instantiate(coinsilv, new Vector2(-3f, Random.Range(-4f, 4f)), Quaternion.identity);
                    else if (i == 3)
                        Instantiate(coinsilv, new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
                    SpawnSilv += Random.Range(1f, intenciveSilv);
                }

            if (Player.Score >= (scr + 2 * numm))
                if (Time.time > SpawnGold)
                {
                    int i = Random.Range(1, 4);
                    if (i == 1)
                        Instantiate(coingold, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                    else if (i == 2)
                        Instantiate(coingold, new Vector2(-3f, Random.Range(-4f, 4f)), Quaternion.identity);
                    else if (i == 3)
                        Instantiate(coingold, new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
                    SpawnGold += Random.Range(1f, intenciveGold);
                }

            if (Player.Score >= (scr + 3 * numm))
                if (Time.time > SpawnEvil)
                {
                    int i = Random.Range(1, 4);
                    if (i == 1)
                        Instantiate(coinevil, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                    else if (i == 2)
                        Instantiate(coinevil, new Vector2(-3f, Random.Range(-4f, 4f)), Quaternion.identity);
                    else if (i == 3)
                        Instantiate(coinsilv, new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
                    SpawnEvil += Random.Range(1f, intenciveEvil);
                }
            if (Player.Score > (scr + 4 * numm + 20))
            {
                scr += 5 * numm;
                numm += 20;
                det += 1;
            }
        
    }

    IEnumerator SpawnTrash()
    {
        while (!Player.lose)
        {
            Instantiate(tresh, new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
            if (Player.Score >= Score1)
            {
                spead = speed1 * 1.02f;
            }
            if (Player.Score >= Score2)
            {
                spead = speed1;
            }
            if (Player.Score >= Score3)
            {
                spead = speed1 * 1.05f;
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
    IEnumerator SpawnCoinCUP()
    {
        while (!Player.lose)
        {
            if (Player.Score >= scr)
            {
                int i = Random.Range(1, 4);
                if (i == 1)
                    Instantiate(coincup, new Vector2(3f, Random.Range(-4f, 4f)), Quaternion.identity);
                else if (i == 2)
                    Instantiate(coincup, new Vector2(-3f, Random.Range(-4f, 4f)), Quaternion.identity);
                else if (i == 3)
                    Instantiate(coincup, new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(1, intenciveCup));
            }
        }
    }
    
}
