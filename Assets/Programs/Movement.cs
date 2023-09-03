using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spi;
    private int MoveSpeed;
    private bool MoveRight, MoveLeft, MoveUp, MoveDown;
    Animator anim;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spi = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        MoveSpeed = 10;
        MoveRight = false;
        MoveLeft = false;
        MoveUp = false;
        MoveDown = false;
    }
 
    public void right()
    {
        MoveRight = true;
    }
 
    public void left()
    {
        MoveLeft = true;
    }
 
    public void up()
    {
        MoveUp = true;
    }
 
    public void down()
    {
        MoveDown = true;
    }
 
    public void stop()
    {
        MoveRight = false;
        MoveLeft = false;
        MoveUp = false;
        MoveDown = false;
        rb.velocity = Vector3.zero;
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
        anim.SetBool("Up", false);
        anim.SetBool("Down", false);
    }
 
    void AnimationState()
    {
        if (MoveRight)
        {
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            spi.flipX = false;
        }
        else if (MoveLeft)
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", true);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            spi.flipX = false;
        }
        else if (MoveUp)
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
        }
        else if (MoveDown)
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", true);
        }
        else
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
        }
    }
 
    void FixedUpdate()
    {
        if (MoveRight)
        {
            rb.velocity = new Vector3(MoveSpeed, rb.velocity.y, 0f);
        }
        else if (MoveLeft)
        {
            rb.velocity = new Vector3(-MoveSpeed, rb.velocity.y, 0f);
        }
        else if (MoveUp)
        {
            rb.velocity = new Vector3(rb.velocity.x, MoveSpeed, 0f);
        }
        else if (MoveDown)
        {
            rb.velocity = new Vector3(rb.velocity.x, -MoveSpeed, 0f);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
 
    void Update()
    {
        AnimationState();
    }
}
