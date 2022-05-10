using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSave : MonoBehaviour
{
    public GameObject gm;
    public string pl1;
    public string pl2;
    public string win;
    public string loss;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(gm);    
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
