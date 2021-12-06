using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 

    }
    
    void FixedUpdate() { 
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime; 
    }
}
