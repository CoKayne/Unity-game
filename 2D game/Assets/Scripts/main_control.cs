using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_control : MonoBehaviour
{
    public string[] playerName;
    static public string left;

    static public string right;
    
    // Start is called before the first frame update
    void Start()
    {
        //left=playerName[0];
        //right=playerName[1];
        GameObject.Find(left).GetComponent<player_info>().setleft();
        GameObject.Find(right).GetComponent<player_info>().setright();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
