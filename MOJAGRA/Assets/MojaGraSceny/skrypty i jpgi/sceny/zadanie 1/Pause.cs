using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    

    // Update is called once per frame
    public void PouseToggle()

    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
                }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
