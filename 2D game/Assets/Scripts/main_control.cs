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
        left = GameObject.Find("CharSave").GetComponent<CharSave>().pl1;
        right = GameObject.Find("CharSave").GetComponent<CharSave>().pl2;
        GameObject.Find(left).GetComponent<player_info>().setleft();
        GameObject.Find(right).GetComponent<player_info>().setright();
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log(left);
         Debug.Log(right);
    }
}