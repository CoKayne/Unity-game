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
    public int respawntime;
    public int stoptime;
    public int blinktime;
    public Animator animator;

    void Start()
    {
        transform.position=new Vector3(ufo_direction*33,high+100,0);
        animator.SetBool("IsBlinking",false);
    }

    public void respawn(){
        ifst=true;
        time=0;
        transform.position=new Vector3(ufo_direction*33,high,0);
    }
    public void stop(){
            ifst=false;
    }
    public void finish(){
        animator.SetBool("IsBlinking",false);
        transform.position=new Vector3(ufo_direction*33,high+100,0);
        ifst=false;
    }
    public void startblink(){
        animator.SetBool("IsBlinking",true);
    }
    void Update()
    {
        time+=Time.deltaTime;
        if(time>respawntime)finish();
        if(time>blinktime)startblink();
        if(time>stoptime)stop();
        if(ifst)transform.position+=new Vector3(0,-1,0)*speed*Time.deltaTime;
    }
}

