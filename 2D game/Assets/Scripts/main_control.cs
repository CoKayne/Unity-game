using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_control : MonoBehaviour
{
    public string[] playerName;
    public string left;

    public string right;
    
    // Start is called before the first frame update
    void Start()
    {
        left=playerName[0];
        right=playerName[1];
        GameObject.Find(right).GetComponent<player_info>().Player_Direction = 1;
        GameObject.Find(left).GetComponent<player_info>().Player_Direction = -1;
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
