using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_info : MonoBehaviour
{
    public float lifeValue = 3;
    public int Player_Direction;
    public string Name;
    public int respawn = 1;
    public float respawnhigh;
    public string[] ufoname;
    public string ownufo;

    public float respawn_position_x;
    public float respawn_position_y;
    // Start is called before the first frame update
    void Start()
    {
        if (Name == "Robert") Robert_ablitity();
        if (Player_Direction == -1) transform.position += new Vector3(1, 0, 0);
    }
    public void setleft()
    {
        Player_Direction = -1;
    }
    public void setright()
    {
        Player_Direction = 1;
    }

    public void respawnposition()
    {
        transform.position = new Vector3(respawn_position_x * Player_Direction, respawn_position_y, 0);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Deadly_things") && !GetComponent<player_movement>().IsInvincible)
        {
            if (Player_Direction == -1) ownufo = ufoname[0];
            else ownufo = ufoname[1];
            lifeValue -= 1f;
            GetComponent<player_movement>().IsInvincible = true;
            if (lifeValue > 0)
            {
                GameObject.Find(ownufo).GetComponent<ufo_control>().respawn(Name);
                transform.position = new Vector3(0, -1000, 0);
            }
            else SceneManager.LoadScene(respawn);
        }

    }
    public void Ghost_ablitity()
    {
        if (Input.GetKeyDown("e")) teleport(GetComponent<player_movement>().facewh);
    }
    public void Robert_ablitity()
    {
        lifeValue++;
    }
    public void Bryant_ablitity()
    {
        if (Player_Direction == -1 && Input.GetKeyDown("e")) ;
        if (Player_Direction == 1 && Input.GetKeyDown("u")) ;
    }
    /*public void player_ablitity(){

    }*/
    void Update()
    {
        if (name == "Ghost") Ghost_ablitity();
        if (name == "Bryant") Bryant_ablitity();
    }

    void FixedUpdate()
    {

    }
    public void teleport(float facewh)
    {
        transform.position += new Vector3(facewh, 0, 0) * 15;
    }

}