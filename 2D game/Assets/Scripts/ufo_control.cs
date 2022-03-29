using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_control : MonoBehaviour
{
    public int ufo_direction;
    public int x;
    public int high;
    public float time=0;
    public int speed;
    private bool ifst=false;
    private bool Isrepawning=false; 
    public float respawntime;
    public float stoptime;
    public float blinktime;
    public string player_name;
    public Animator animator;

    void Start()
    {
        transform.position=new Vector3(ufo_direction*33,high+100,0);
        animator.SetBool("IsBlinking",false);
    }

    public void respawn(string pn){
        player_name=pn;
        ifst=true;
        Isrepawning=true;
        time=0;
        transform.position=new Vector3(ufo_direction*33,high,0);
    }
    public void stop(){
            ifst=false;
            GameObject.Find(player_name).GetComponent<player_movement>().IsInvincible=false;
    }
    public void startblinking(){
        animator.SetBool("IsBlinking",true);
    }
    public void finish(){
        animator.SetBool("IsBlinking",false);
        transform.position=new Vector3(ufo_direction*33,high+100,0);
        Isrepawning=false;
        animator.SetBool("IsBlinking",false);
    }
    void Update()
    {
        time+=Time.deltaTime;
        if(time>respawntime&&Isrepawning)finish();
        if(time>blinktime&&Isrepawning)startblinking();
        if(time>stoptime&&Isrepawning)stop();
        if(ifst&&Isrepawning)transform.position+=new Vector3(0,-1,0)*speed*Time.deltaTime;
    }
}