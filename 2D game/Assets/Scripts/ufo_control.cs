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
    void Start()
    {
        transform.position=new Vector3(ufo_direction*33,high+100,0);
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
        transform.position=new Vector3(ufo_direction*33,high+100,0);
        ifst=false;
    }
    void Update()
    {
        time+=Time.deltaTime;
        if(time>respawntime)finish();
        if(time>stoptime)stop();
        if(ifst)transform.position+=new Vector3(0,-1,0)*speed*Time.deltaTime;
    }
}

