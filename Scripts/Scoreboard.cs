using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public float Score;
    public Text Scoretext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Setur upp score textaborðið á skjánum í gegnum lykkju
        Scoretext.text = "Score: " + Score;
    }
}
