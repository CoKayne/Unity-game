using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_control : MonoBehaviour
{
    public int ufo_direction;
    public int x;
    public int high;
    public float time = 0;
    public int speed;
    private bool ifst = false;
    private bool Isrepawning = false;
    public float respawntime;
    public float stoptime;
    public float blinktime;
    public string player_name;
    public string Character_picture_name;
    public Animator animator;
    private string Character_picture_last_name_left = "_picture_left";
    private string Character_picture_last_name_right = "_picture_right";

    void Start()
    {
        transform.position = new Vector3(ufo_direction * 33, high + 100, 0);
        animator.SetBool("IsBlinking", false);
    }

    public void respawn(string pn)
    {
        player_name = pn;
        if (ufo_direction == -1) Character_picture_name = player_name + Character_picture_last_name_left;
        else Character_picture_name = player_name + Character_picture_last_name_right;
        ifst = true;
        Isrepawning = true;
        time = 0;
        transform.position = new Vector3(ufo_direction * 33, high, 0);
        GameObject.Find(Character_picture_name).GetComponent<Character_picture_control_left>().respawn_position(ufo_direction);
    }
    public void stop()
    {
        ifst = false;
        GameObject.Find(Character_picture_name).GetComponent<Character_picture_control_left>().playermove();

    }
    public void startblinking()
    {
        animator.SetBool("IsBlinking", true);
        GameObject.Find(Character_picture_name).GetComponent<Character_picture_control_left>().leave();
        GameObject.Find(player_name).GetComponent<player_movement>().IsInvincible = false;
    }
    public void finish()
    {
        animator.SetBool("IsBlinking", false);
        transform.position = new Vector3(ufo_direction * 33, high + 100, 0);
        Isrepawning = false;
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time > respawntime && Isrepawning) finish();
        if (time > blinktime && Isrepawning) startblinking();
        if (time > stoptime && Isrepawning) stop();
        if (ifst && Isrepawning)
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
            GameObject.Find(Character_picture_name).GetComponent<Character_picture_control_left>().respawn_move(speed);
        }
    }
}