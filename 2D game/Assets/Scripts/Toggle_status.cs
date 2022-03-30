using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_status : MonoBehaviour
{
    public Toggle toggle;
    void Update(){
        if(toggle.isOn == true){
            GetComponentInChildren<Image>().color = new Color32(99, 232, 231, 255);
        }else{
            GetComponentInChildren<Image>().color = new Color32(99, 232, 231, 0); 
        }
    }
}
