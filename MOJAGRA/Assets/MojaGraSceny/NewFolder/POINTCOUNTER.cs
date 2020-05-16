using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class POINTCOUNTER : MonoBehaviour
{
    public Text pointText;
     int points = 0;

    void Update()
    {
        pointText.text = "ODBITYCH CIOSÓW: " + points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "1")
        {

            points += 1;
            
        }
    }
}



