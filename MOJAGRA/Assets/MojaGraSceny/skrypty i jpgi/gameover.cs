using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class gameover : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "1")
        {
            SceneManager.LoadScene("GAMEOVER"); // loads scene When player enter the trigger collider
        }
    }
}
