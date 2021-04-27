using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100f;
    public float Score = 0;
    public Text Scoretext;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("skjOtttttttt");   // Leyfi þessu bara að vera.    
           
            //GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            //Setur bulletið í gang og leyfir því að róterast áfram.
            GameObject instBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            //Skynjar Rigidbody á bulletinu
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            //Hleypir bulletinu áfram
            instBulletRigidbody.AddForce(transform.forward * speed);
            Destroy(instBullet, 3f);//kúl eytt eftir 0.5sek
            Score = Score + 1; // Gefur stig ef hitt er í mark
            
           
        }
    }
}
