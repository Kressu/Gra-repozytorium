using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed = 3;
    private Vector2 movment;
    public float jumpForce = 5;
    private bool canJump = false;
    private bool ground = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("jump")&& ground)
        {
            canJump = true;
        }
        
    }

     void FixedUpdate()
    {
        rb.velocity = new Vector2(movment.x *playerSpeed, rb.velocity.y);
        if (canJump=true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
            ground = false;
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            ground = true;
        }
    }
}
