using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound;
    public static AudioClip clickSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    public static void PlaySound (string clip){
        switch (clip){
        case "jump":
            audioSrc.PlayOneShot(jumpSound);
            break;
        }
    }

    public static void PlayClick (string clip){
        // clickSound = Resources.Load<AudioClip>("click"); 
        switch (clip){
        case "click":
            audioSrc.PlayOneShot(clickSound);
            break; 
        }
    }
    void Start()
    {
       jumpSound = Resources.Load<AudioClip>("jump"); 
       clickSound = Resources.Load<AudioClip>("click"); 

       audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}