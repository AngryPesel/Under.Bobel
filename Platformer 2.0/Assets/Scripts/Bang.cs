using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour
{
    public GameObject coin;
    public AudioClip Coin;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GetComponent<AudioSource>().clip = Coin;
            GetComponent<AudioSource>().Play();
        }
    }
}
