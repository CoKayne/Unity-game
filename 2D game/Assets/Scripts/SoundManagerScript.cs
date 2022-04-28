using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound;
    public static AudioClip clickSound;
    public static AudioClip click2Sound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    public static void PlaySound (string clip){
        switch (clip){
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "click":
                audioSrc.PlayOneShot(clickSound);
                break;
            case "click2":
                audioSrc.PlayOneShot(click2Sound);
                break;
        }
    }

    void Start()
    {
       jumpSound = Resources.Load<AudioClip>("jump"); 
       clickSound = Resources.Load<AudioClip>("click"); 
       click2Sound = Resources.Load<AudioClip>("click2");

       audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}