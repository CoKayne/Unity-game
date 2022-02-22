using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_control : MonoBehaviour
{
    public string[] rocketname;
    public float timer=0f;
    public float spwntime=0f;
    public string launch;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>spwntime){
            timer=0;
            launch=rocketname[Random.Range(0,rocketname.Length)];
            GameObject.Find(launch).GetComponent<Rocket_movement>().randomway();
        }
    }
}
