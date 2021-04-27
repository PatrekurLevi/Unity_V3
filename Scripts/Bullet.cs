using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class Bullet : MonoBehaviour
{
    public float speed=20f;
    public Rigidbody rb;
    public int damage = 10;
    public GameObject sprengjan;
    public static int count;//klasabreyta
    //private Text countText;
    public AudioSource explosionsound;
    public AudioSource coinsound;
    public float scoreAmount = 10;
    public GameObject scoreboard;
    void Start()
    {
        //Færir bulletið áfram miðað við hraða
        rb.velocity = transform.forward * speed;
        scoreboard = GameObject.FindWithTag("Score");
        // countText = GameObject.Find("Text").GetComponent<Text>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag=="raudurkassi")
        {
            //Ef kúlan kemur við rauða kassann þá sprengist og eyðist upp.
            scoreboard.GetComponent<Scoreboard>().Score += scoreAmount;
            //Spilar sprengju hljóð
            explosionsound.Play(0);
            //Spilar score hljóð
            coinsound.Play(0);
            Destroy(collision.gameObject);//eyðir kassanum
            //Destroy(gameObject);//eyða kúlunni þarf ekki eyðist eftir 0.5 sek                 
            Sprengja();//framkvæmir sprengju
        }
        if (collision.collider.tag == "pinkbox")
        {
            //Ef kúlan kemur við bleika kassann þá sprengist og eyðist upp.
            scoreboard.GetComponent<Scoreboard>().Score += 50;
            explosionsound.Play(0);
            coinsound.Play(0);
            Destroy(collision.gameObject);//eyðir kassanum
            //Destroy(gameObject);//eyða kúlunni þarf ekki eyðist eftir 0.5 sek                 
            Sprengja();//framkvæmir sprengju
        }

    }
    void Sprengja()
    {
        //Gefur upp staðsetninguna á sprengjunni
        Instantiate(sprengjan, transform.position, transform.rotation);
    }
}
