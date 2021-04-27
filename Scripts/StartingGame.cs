using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingGame : MonoBehaviour
{
    public bool isStarted;
    public GameObject Panel;
    public Text startgame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted == false)
        {
        // Setur leikinn á stopp
            Time.timeScale = 0;
        // Setur upp panelið til að blokka skjáinn
            Panel.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
        // Ef ýtt er á Space þá er leikurinn virkur
            isStarted = true;
            Time.timeScale = 1;
        // Tekur panelið frá og leyfir notendanum að sjá
            Panel.gameObject.SetActive(false);
            startgame.gameObject.SetActive(false);
        }
    }
}
