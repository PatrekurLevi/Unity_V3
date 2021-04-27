using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ovinur : MonoBehaviour
{
    public static int health = 30;
    public Transform player;
    Text texti;
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //texti= GameObject.Find("Text2").GetComponent<Text>();
        rb = this.GetComponent<Rigidbody>();
        //texti.text = "Líf " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Lætur kúluna elta playerinn eða staðsetninguna sem playerinn er á.
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();
        movement = stefna;
    }
    private void FixedUpdate()
    {
        //Uppfærir hreyfinguna á kúlunni
        Hreyfing(movement);
    }
    void Hreyfing(Vector3 stefna)
    {
        //Gefur hraðann á kúlunni
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Ef hún snertir playerinn missir hann stig og hverfur
        if (collision.collider.tag=="Player") 
        {
            Debug.Log("Leikmaður fær í sig óvin");
           // TakeDamage(10);
            gameObject.SetActive(false);
        }
    }
    public void TakeDamage(int damage)
    {
        //Uppfærir lífið á playernum
        Debug.Log("health er núna" + (health).ToString());
        health -= damage;
        texti.text = "Líf " + health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
            health = 30;
            Bullet.count = 0;//núll stilli stigin 
            texti.text = "Líf " + health.ToString();
        }

    }
    

}
