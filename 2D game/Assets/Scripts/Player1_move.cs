using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_move : MonoBehaviour
{
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    // private int extraJumps;
    // public int extraJumpsValue;
    public float speed = 1f;
    public float jumpforce = 1f;
    public float doubleJumpForce = 1f;
    private bool doubleJump;
    public Rigidbody2D rb;

    void start(){
        rb = GetComponent<Rigidbody2D>();
        // extraJumps = extraJumpsValue;
    }

   /* int moving_input(){               直接位移，座標移動
        if(Input.GetKey("j")){
            return -1;
        }
        if(Input.GetKey("l")){
            return 1;
        }
        return 0;
    } */
    void Update(){

/*        if(Input.GetKeyDown("w")&& Mathf.Abs(rb.velocity.y) < 0.001f){
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
        }

        if(isGrounded == true){ 
                extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown("w") && extraJumps > 0){
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
            extraJumps --;
        }else if(Input.GetKeyDown("w") && extraJumps == 0 && isGrounded == true){ 
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
        }
*/

        if(isGrounded && !Input.GetKey("w")){
            doubleJump = false;
        }

        if(Input.GetKeyDown("w")){
            if(isGrounded || doubleJump){
                rb.velocity = new Vector2(rb.velocity.x, doubleJump ? doubleJumpForce : jumpforce);
                SoundManagerScript.PlaySound("jump");
                doubleJump = !doubleJump;
            }
        }
        
        if(Input.GetKeyUp("w") && rb.velocity.y > 0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }   

    void FixedUpdate() {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, movement)){
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        
    }

}