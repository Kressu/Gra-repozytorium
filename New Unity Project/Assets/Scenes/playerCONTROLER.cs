using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCONTROLER : MonoBehaviour
{
    public float playerSpeed = 3;
    private Vector2 movment;
    private SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
        print(movment.x);
        transform.position += new Vector3(playerSpeed * movment.x * Time.deltaTime, playerSpeed * movment.y * Time.deltaTime, 0);
        if (movment.x < 0)
        {
            m_SpriteRenderer.flipX = false;
        }
        else if (movment.x > 0)
        {
            m_SpriteRenderer.flipX = true;
        }
    }
}
