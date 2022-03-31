using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_bgm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicContinue>().PlayMusic(); 
    }
}
