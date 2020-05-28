using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DaggerSpawn : MonoBehaviour
{

    private float speed = 0.2f;
    private double chance = 80;
    public Rigidbody2D pox;
        void Start()
    {  
        InvokeRepeating("Spawn", 2f, 2f);
    }


    void Spawn()
    {
        int x = Random.Range(0, 100);
        if (x > chance)
        {
            Rigidbody2D instance = Instantiate(pox, transform);
            instance.transform.position = instance.transform.position + Vector3.right;
            instance.velocity = -instance.transform.position * speed;
        }
        chance-=0.2;
        speed += 0.01f;
    }
}
