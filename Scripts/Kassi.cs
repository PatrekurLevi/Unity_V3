using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kassi : MonoBehaviour
{
    
    private void Update()
    {
        if (transform.position.y < -10)
        {
            //Eyðir kassanum þegar kúlan fer í hann
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    
}
