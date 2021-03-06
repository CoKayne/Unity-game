using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public LayerMask whatIsGround;
    private bool isGrounded;

    public Transform groundCheck;
    public float checkRadius;
    public float doubleJumpForce = 1f;
    public int doubleJump = 0;
    public float speed = 1f;
    public float jumpforce = 1f;
    public Rigidbody2D rb;
    public float facewh = 0f;

    public int pld;
    public bool IsInvincible = false;
    public player_info info;
    public Animator animator;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("Iswalking", false);
        animator.SetBool("Isjumping", false);
        // extraJumps = extraJumpsValue;
    }

    public void pl1_movement()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        var movement = Input.GetAxis("Horizontal");
        if (movement > 0)
        {
            facewh = 1f;
            animator.SetBool("Iswalking", true);
        }
        else if (movement < 0)
        {
            facewh = -1f;
            animator.SetBool("Iswalking", true);
        }
        else
        {
            animator.SetBool("Iswalking", false);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

    }
    public void pl2_movement()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        var movement = Input.GetAxis("Horizontal2");
        if (movement > 0)
        {
            facewh = 1f;
            animator.SetBool("Iswalking", true);
        }
        else if (movement < 0)
        {
            facewh = -1f;
            animator.SetBool("Iswalking", true);
        }
        else
        {
            animator.SetBool("Iswalking", false);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;
        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

    }

    public void pl1_jump()
    {
        if (isGrounded && !Input.GetKey("w"))
        {
            doubleJump = 0;
            animator.SetBool("Isjumping", false);
        }

        if (Input.GetKeyDown("w"))
        {
            if (doubleJump < 2)
            {
                animator.SetBool("Isjumping", true);
                rb.velocity = new Vector2(rb.velocity.x, doubleJump == 1 ? doubleJumpForce : jumpforce);
                SoundManagerScript.PlaySound("jump");
                doubleJump++;
            }
        }

        if (Input.GetKeyUp("w") && rb.velocity.y > 0f)
        {
            animator.SetBool("Isjumping", true);
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }
    public void pl2_jump()
    {
        if (isGrounded && !Input.GetKey("i"))
        {
            doubleJump = 0;
            animator.SetBool("Isjumping", false);
        }

        if (Input.GetKeyDown("i"))
        {
            if (doubleJump < 2)
            {
                animator.SetBool("Isjumping", true);
                rb.velocity = new Vector2(rb.velocity.x, doubleJump == 1 ? doubleJumpForce : jumpforce);
                SoundManagerScript.PlaySound("jump");
                doubleJump++;
            }
        }

        if (Input.GetKeyUp("i") && rb.velocity.y > 0f)
        {
            animator.SetBool("Isjumping", true);
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }

    void Update()
    {
        pld = GetComponent<player_info>().Player_Direction;
        if (pld == -1) pl1_jump();
        if (pld == 1) pl2_jump();
    }

    void FixedUpdate()
    {
        if (pld == -1) pl1_movement();
        if (pld == 1) pl2_movement();
    }
}