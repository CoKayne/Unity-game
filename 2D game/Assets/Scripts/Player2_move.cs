using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_move : MonoBehaviour
{
    public LayerMask whatIsGround;
    private bool isGrounded;

    public Transform groundCheck;
    public float checkRadius;
    public int extraJumpsValue;
    private int extraJumps;
    public float speed = 1f;
    public float jumpforce = 1f;
    public Rigidbody2D rb;

    void start(){
        rb = GetComponent<Rigidbody2D>();
        extraJumps = extraJumpsValue;
    }
    void Update(){
        
        // if(Input.GetKeyDown("i") && Mathf.Abs(rb.velocity.y) < 0.001f){
        //     rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        //     SoundManagerScript.PlaySound("jump");
        // }
        if(isGrounded == true){
            extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown("i") && extraJumps > 0){
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
            extraJumps --;
        
        }else if(Input.GetKeyDown("i") && extraJumps == 0 && isGrounded == true){ 
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
        }
    }       

    void FixedUpdate() {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        var movement = Input.GetAxis("Horizontal2");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, movement)){
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }
}