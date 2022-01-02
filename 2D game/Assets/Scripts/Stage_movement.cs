using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;

    public  float timer= 0f;

    public  float speedup= 0f;

    public  float speedlimit;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 

    }
    
    void FixedUpdate() { 
            timer+=Time.deltaTime;
            if(timer>1&&speed<speedlimit){
                timer=0f;
                speed+=speedup;
            }

            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime; 
    }
}
