using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_movement : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float maxX = 0f;
    public float maxY = 0f;
    public float minX = 0f;
    public float minY = 0f;
    public float goingWhere = 0f; // 1right 2down 3left
    public float limitX = 0f;
    public float limitY = 0f;
    public float speed = 0f;
    public bool canGo = false;
    public float timer=0f;
    void Start(){  
        limitY = transform.position.y;
        limitX = transform.position.x;
        if(goingWhere == 1){
            x = 1; 
        }
        if(goingWhere == 2){
            y =- 1; 

        }
        if(goingWhere == 3){
            x =- 1; 
        }
    }
    public void go(){
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * speed;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Deadly_things")){
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>2)
        go();
    }
}
