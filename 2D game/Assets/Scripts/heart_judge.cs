using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_judge : MonoBehaviour
{
    public int order;
    public int heartDirection;
    public float disappearDistance = 0f;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(heartDirection==1){
        //     if(GameObject.Find(GameObject.Find("main").GetComponent<main_control>().right()).GetComponent<player_info>().lifeValue){

        //     }
        // }
        // if(order < lifeValue){
            // transform.position += new Vector3(disappearDistance, 0, 0) * heartDirection;
        // }     
    }
}