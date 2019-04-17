using System;
using System.Collections;
using UnityEngine;

public class SpawnTresh : MonoBehaviour
{
    public GameObject tresh;
    public GameObject coincup;
    public GameObject coinsilv;
    public GameObject coingold;
    public GameObject coinevil;
    public GameObject Shild;
    public GameObject SpeedUP;
    public GameObject Gem;

    public static int Score;
    public static float spead = 3f;
    public static float intenciveCup = 5f;
    public static float intenciveSilv = 7f;
    public static float intenciveGold = 9f;
    public static float intenciveEvil = 5f;

    private static float timeCup = 0;
    private static float timeSilv = 0;
    private static float timeGold = 0;
    private static float timeEvil = 0;
    private static float time = 0;
    private static float timeShild = 20f;
    private static float timeSpeedUP = 30f;
    private static float timeGem = 50f;

    public float speed1 = 3f;
    int n = 30;
    int scr = 0;
    int numm = 10;
    int k = 20;
    public static int det = 1;
    int bonus;

    public int Score1 = 10;
    public int Score2 = 20;
    public int Score3 = 30;

    void Start()
    {
        bonus = 0;
        scr = 0;
        numm = 10;
        k = 20;
        det = 1;
        timeCup = intenciveCup;
        timeSilv = intenciveSilv;
        timeGold = intenciveGold;
        timeEvil = intenciveEvil;
        timeShild = 20f;

        spead = 3f;

        StartCoroutine(SpawnTrash());
    }

    private void Update()
    {
        if (!Player.lose)
        {
            time += Time.deltaTime;
            if (time > timeCup)
            {
                createCoinCup();
                timeCup = time + UnityEngine.Random.Range(1, intenciveCup);
            }
            if (Player.Score >= (scr + numm))
                if (time > timeSilv)
                {

                    createCoinSILV();
                    timeSilv = time + UnityEngine.Random.Range(1, intenciveSilv);
                }

            if (Player.Score >= (scr + numm * 3))
                if (time > timeGold)
                {
                    createCoinGold();
                    timeGold = time + UnityEngine.Random.Range(1, intenciveGold);
                }

            if (Player.Score >= (scr + numm * 6))
                if (time > timeEvil)
                {
                    createCoinEVIL();
                    timeEvil = time + UnityEngine.Random.Range(1, intenciveEvil);

                }
            if (Player.Score > (scr + 6 * numm + 40))
            {
                scr += 5 * numm;
                numm += 20;
                det += 1;
                timeCup -= 1f;
                timeSilv -= 0.5f;
                timeGold -= 0.2f;
                timeEvil -= 0.1f;
                bonus++;
            }
            if (bonus > 0)
            {
                if (time > timeShild)
                {
                    createCoinSHILD();
                    timeShild = time + UnityEngine.Random.Range(20f, 60f);
                }
            }
            if (bonus > 1)
            {
                if (time > timeSpeedUP)
                {
                    createSpeedUP();
                    timeSpeedUP = time + UnityEngine.Random.Range(20f, 60f);
                }
            }
            if (Player.Score > 1)
            {
                if (time > timeGem)
                {
                    createGem();
                    timeGem = time + UnityEngine.Random.Range(20f, 60f);
                }
            }
            if (Player.lose)
            {
                StopAllCoroutines();
            }
        }
        else
        {
            timeCup = 0;
            timeSilv = 0;
            timeGold = 0;
            timeEvil = 0;
            timeGem = 0;
            time = 0;
        }       
    }

    IEnumerator SpawnTrash()
    {
        while (!Player.lose)
        {
            Instantiate(tresh, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
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
                spead = speed1 * 0.98f;
                speed1 = spead;
                n += 10;
                Score1 = Score1 + n;
                n += 20;
                Score2 = Score2 + n;
                n += 30;
                Score3 = Score3 + n;
            }
            yield return new WaitForSeconds(spead);
        }

    }

    void createCoinCup()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(coincup, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(coincup, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(coincup, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }

    void createCoinSILV()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(coinsilv, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(coinsilv, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(coinsilv, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }

    void createCoinGold()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(coingold, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(coingold, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(coingold, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }

    void createCoinEVIL()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(coinevil, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(coinevil, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(coinevil, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }

    void createCoinSHILD()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(Shild, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(Shild, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(Shild, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }

    void createSpeedUP()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(SpeedUP, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(SpeedUP, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(SpeedUP, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }

    void createGem()
    {
        int i = UnityEngine.Random.Range(1, 4);
        if (i == 1)
            Instantiate(Gem, new Vector2(3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 2)
            Instantiate(Gem, new Vector2(-3f, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
        else if (i == 3)
            Instantiate(Gem, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
    }
}
