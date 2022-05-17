using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom_ablitity_control : MonoBehaviour
{
    public string[] rocketname;
    public GameObject[] rockets;
    public GameObject cloneroket;
    public string rocketToLaunch;
    private bool spawnPlaceDecided = false;
    public int randomnumber = 0;
    public float launchx;
    public float launchy;
    public float timer;
    public float cool_down;

    public bool okornot = false;

    void Start()
    {

    }

    public void launch_rocket()
    {
        randomnumber = Random.Range(0, rocketname.Length);
        rocketToLaunch = rocketname[randomnumber];
        launchx = Random.Range(GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().maxX, GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().minX);
        launchy = Random.Range(GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().maxY, GameObject.Find(rocketToLaunch).GetComponent<Rocket_movement>().minY);
        cloneroket = Instantiate(rockets[randomnumber], new Vector3(launchx, launchy, 0), Quaternion.identity);
        Destroy(cloneroket, 10);
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cool_down && GetComponent<player_info>().Player_Direction == -1 && Input.GetKeyDown("e")
        && okornot) launch_rocket();
        if (timer > cool_down && GetComponent<player_info>().Player_Direction == 1 && Input.GetKeyDown("u") && okornot) launch_rocket();
    }

}
