using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_move : MonoBehaviour
{
    public float speed = 1f;
    public float jumpforce = 1f;
    public Rigidbody2D rb;

    void start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        
        if(Input.GetKeyDown("i") && Mathf.Abs(rb.velocity.y) < 0.001f){
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jump");
        }
    }       

    void FixedUpdate() {
        
        var movement = Input.GetAxis("Horizontal2");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, movement)){
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }
}