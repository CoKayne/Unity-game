using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_movement : MonoBehaviour
{
    public float x=0f;
    public float y=0f;
    public float maxX=0f;
    public float maxY=0f;
    public float minX=0f;
    public float minY=0f;
    public float goingwh=0f;// 1right 2down 3left
    public float limitx=0f;
    public float limity=0f;
    public float speed=0f;
    public bool decide=false;
    void Start()
    {
        
        
    }

    public void randomway(){
        transform.position=new Vector3(Random.Range(maxX,minX),Random.Range(maxY,minY),0);
        if(goingwh==1){x=1;limity=transform.position.y;}
        if(goingwh==2){y=-1;limitx=transform.position.x;}
        if(goingwh==3){x=-1;limity=transform.position.y;}
        decide=true;
    }
    public void go(){
            transform.position+=new Vector3(x,y,0)*Time.deltaTime*speed;

    }
    // Update is called once per frame
    void Update()
    {
        if(decide) go();
        if(Mathf.Abs(transform.position.x)>Mathf.Abs(limitx)&&Mathf.Abs(transform.position.y)>Mathf.Abs(limity))decide= false;
    }
}
