using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float minrange = -48f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y <= minrange){
           Destroy(this.gameObject);
       } 
    }
}
