using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_judge : MonoBehaviour
{
    public int order;
    public int heartDirection=50;
    public float disappearDistance = 0f;
    public string player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void getout(){
        transform.position+=new Vector3(disappearDistance,0,0)*heartDirection;
    }
    // Update is called once per frame
    void Update()
    {
        if(heartDirection == -1) player = GameObject.Find("main").GetComponent<main_control>().left;
        if(heartDirection == 1) player = GameObject.Find("main").GetComponent<main_control>().right;
        if(GameObject.Find(player).GetComponent<player_info>().lifeValue < order) getout();
    }
}