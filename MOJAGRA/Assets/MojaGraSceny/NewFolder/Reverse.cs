using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reverse : MonoBehaviour
{
 
 

    // Update is called once per frame
    void OnMouseDown()
    {
        var cmp = GetComponent<Rigidbody2D>();
        cmp.velocity = -cmp.velocity *50;
  
    }
}
