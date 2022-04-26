using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_picture_control_left : MonoBehaviour
{
    // Start is called before the first frame update
    public string Character_name;

    public float respawn_high;
    void Start()
    {

    }

    public void respawn_position(int direction)
    {
        transform.position = new Vector3(33 * direction, respawn_high, 0);
    }

    public void respawn_move(int speed)
    {
        transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
    }
    public void leave()
    {
        transform.position = new Vector3(0, 100, 0);
    }
    public void playermove()
    {
        GameObject.Find(Character_name).GetComponent<player_info>().respawnposition();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
