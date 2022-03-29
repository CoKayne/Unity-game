using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_status : MonoBehaviour
{
    public Toggle toggle;

    public void switchOn(bool status){
        if(toggle.isOn == true){
            GetComponentInChildren<Image>().color.a.Equals(255);
        }else{
            GetComponentInChildren<Image>().color.a.Equals(0);
        }
    }
}
