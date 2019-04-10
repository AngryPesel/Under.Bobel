using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCrush : MonoBehaviour
{
    private Animator anim;
    private bool Crush = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("Crush", true);
        }

        StartCoroutine(CrashTime());


        Destroy(collision.gameObject);
    }

    IEnumerator CrashTime()
    {
        yield return new WaitForSeconds(0.2f);
    }
}
