using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    bool MoveLeft;
    bool MoveRight;
    bool MoveForward;
    bool MoveBackward;
    float horizontalMove; 
    float verticalMove;
    public float speed = 300;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    
    public void PointerDownLeft()
    {
        MoveLeft = true;
    }

    public void PointerUpLeft()
    {
        MoveLeft = false;
    }

    public void PointerDownRight()
    {
        MoveRight = true;
    }

    public void PointerUpRight()
    {
        MoveRight = false;
    }

    public void PointerDownHigh()
    {
        MoveForward = true;
    }

    public void PointerUpHigh()
    {
        MoveForward= false;
    }

    public void PointerDownLow()
    {
        MoveBackward = true;
    }

    public void PointerUpLow()
    {
        MoveBackward = false;
    }
   
    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (MoveLeft)
        {
            horizontalMove = -speed;
        }
        else if (MoveRight)
        {
            horizontalMove = speed;
        }


        if (MoveForward)
        {
            verticalMove = speed;
        }
        else if (MoveBackward)
        {
            verticalMove = -speed;
        }
        
    }

    private void FixedUpdateUpdate()
    {
        rb.velocity = new Vector3(horizontalMove * Time.deltaTime, rb.velocity.y, verticalMove * Time.deltaTime);
    
    }
}
