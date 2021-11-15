using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
        if(Input.GetKey("space")){          //activate slow motion
            Time.timeScale = 0.25f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            
        }

        if(Input.GetKeyUp("space")){        //deactivate slow motion
            Time.timeScale = 1; 
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    
    }
}
