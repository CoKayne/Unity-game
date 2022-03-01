using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_control : MonoBehaviour
{
    public string[] rocketname;
    public GameObject[] rockets;
    public GameObject cloneroket;
    public float rocketTimer=0f;
    public float rocketSpawntime = 0f;
    public string rocketToLaunch;
    public float decreaseTime = 0f;
    private bool spawnPlaceDecided = false;
    public int randomnumber=0;
    void Start()
    {
        
    }
    public void destrory(){
        Destroy(cloneroket,0.01f);
    }
    // Update is called once per frame
    void Update()
    {
        rocketTimer += Time.deltaTime;
        if(rocketTimer > rocketSpawntime){  
            randomnumber=Random.Range(0,rocketname.Length);
            rocketToLaunch = rocketname[randomnumber];
            cloneroket=Instantiate(rockets[randomnumber],new Vector3 (Random.Range (GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().maxX,GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().minX), Random.Range (GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().maxY,GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().minY), 0), Quaternion.identity);
            GameObject.Find(rocketToLaunch).GetComponentInChildren<WowMark_blink>().warningEnd = true;
            spawnPlaceDecided = false;
            rocketTimer = 0;
        }        
    }

    private void FixedUpdate() {

    }
}
