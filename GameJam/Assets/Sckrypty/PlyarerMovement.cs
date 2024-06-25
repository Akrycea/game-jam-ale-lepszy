using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyarerMovement : MonoBehaviour
{
    public bool walking;
    private float speed = 5f;
    public bool sprint = false;
    float speedX, speedY;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Sprint();

        isWalking();
    }

    void FixedUpdate()
    {
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;
        rb.velocity = new Vector2(speedX, speedY);

    }

    private void Sprint ()
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
            speed = 8f;
            sprint = true;
            }
           else
            {
            speed = 5f;
            sprint = false;
            }
            
        }
    public void isWalking()
    {
        if (speed < 0f)
        {
            walking = true;
        }
        else
            walking = true;
    }
   
}
