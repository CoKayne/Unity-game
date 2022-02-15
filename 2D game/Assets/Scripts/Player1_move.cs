using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_move : MonoBehaviour
{
    public BoxCollider2D feet_collider;
    public float speed = 1f;
    public float jumpforce = 1f;
    public Rigidbody2D rb;

    public int count=0;

    void start(){
        rb = GetComponent<Rigidbody2D>();
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
        if(Input.GetKeyDown("w")&& Mathf.Abs(rb.velocity.y) < 0.001f){
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
        }
    }   

    void FixedUpdate() {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, movement)){
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        
    }


}