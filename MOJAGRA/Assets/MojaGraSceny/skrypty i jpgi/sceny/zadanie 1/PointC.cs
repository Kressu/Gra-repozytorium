using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointC : MonoBehaviour
{
    public Text pointText;
    private int points = 0;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        pointText.text = "SCORE:" + points.ToString(); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.gameObject.tag == "Box")
        {
            points += 1;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
