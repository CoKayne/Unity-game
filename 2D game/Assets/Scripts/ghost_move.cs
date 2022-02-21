using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_move : MonoBehaviour
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
    private int doubleJump = 0;
    public Rigidbody2D rb;
    public float teleportcountdown=0f;
    public float teleportcountdownlimit=0f;
    public float telepordistance=0f;
    public float facewh=0f;

    void start(){
        rb = GetComponent<Rigidbody2D>();
        // extraJumps = extraJumpsValue;
    }

    void teleport(float movement){
        teleportcountdown=0f;
        transform.position += new Vector3(movement, 0, 0)*telepordistance;
    return;
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
        teleportcountdown += Time.deltaTime;
        if(teleportcountdown >= teleportcountdownlimit && Input.GetKeyDown("e"))teleport(facewh);

        if(isGrounded && !Input.GetKey("w")){
            doubleJump = 0;
        }

        if(Input.GetKeyDown("w")){
            if(doubleJump<2){
                rb.velocity = new Vector2(rb.velocity.x, doubleJump==1 ? doubleJumpForce : jumpforce);
                SoundManagerScript.PlaySound("jump");
                doubleJump ++;
            }
        }
        
        if(Input.GetKeyUp("w") && rb.velocity.y > 0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }   

    void FixedUpdate() {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        var movement = Input.GetAxis("Horizontal");
        if(movement>0)facewh=1f;
        else if(movement<0) facewh=-1f;
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, movement)){
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        
    }

}