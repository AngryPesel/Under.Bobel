using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ScinesDataBase;

public class MainMenu : MonoBehaviour
{
    public GameObject Shop;

    private bool pause = false;

    public AudioClip Song;
    private AudioSource audioSorse;

    private bool mute = false;
    /*public static string LGBT = "LGBT";
    public static string Catty = "Catty";
    public static string Orange = "Orange";
    public static string Candy = "Candy";
    public static string Dog = "Dog";

    public static int LGBT_PRICE = 1000;
    public static int Catty_PRICE = 5000;
    public static int Orange_PRICE = 10000;
    public static int Candy_PRICE = 20000;
    public static int Dog_PRICE = 27000;*/

    //public static List<ScineEntity> list;

    private void Start()
    {
        /*load();
        if (list.Count == 0)
        {
            initData();
        }*/
        audioSorse = GetComponent<AudioSource>();
        audioSorse.clip = Song;
        audioSorse.Play();
    }

    public void PlayGame()
    {
        Player.lose = false;
        SceneManager.LoadScene("Scene1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ToShop()
    {
        Shop.SetActive(true);
    }

    public void ToMenu()
    {
        Shop.SetActive(false);
    }

    /*public void load()
    {
        ScinesDataBase database = new ScinesDataBase();
        Debug.Log("URA1");
        database.createTable();
        Debug.Log("URA2");
        list = database.getScines();
        Debug.Log("URA3");
        database.close();
        Debug.Log("URA4");
    }

    public void initData()
    {
        ScinesDataBase database = new ScinesDataBase();
        Debug.Log("URA1");
        database.createTable();
        database.insertData(new ScinesDataBase.ScineEntity(LGBT, LGBT_PRICE, 0));
        database.insertData(new ScinesDataBase.ScineEntity(Catty, Catty_PRICE, 0));
        database.insertData(new ScinesDataBase.ScineEntity(Orange, Orange_PRICE, 0));
        database.insertData(new ScinesDataBase.ScineEntity(Candy, Candy_PRICE, 0));
        database.insertData(new ScinesDataBase.ScineEntity(Dog, Dog_PRICE, 0));
        Debug.Log("URA2");
        database.close();
        Debug.Log("URA3");
    }*/

    public void Mute()
    {
        if (!mute)
        {
            audioSorse.Pause();
            mute = true;
        }
        else if (mute)
        {
            audioSorse.Play();
            mute = false;
        }
    }
}
