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
    public string[] ufoname;
    public string ownufo;
    // Start is called before the first frame update
    void Start()
    { 
        if(Name=="Robert")Robert_ablitity();
    }
    public void setleft(){
       Player_Direction =- 1;
    }
    public void setright(){
       Player_Direction = 1;
    }

    public void respawnposition(){
       transform.position = new Vector3(33 * Player_Direction, 43, 0);
       GameObject.Find(ownufo).GetComponent<ufo_control>().respawn(Name);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Deadly_things")&&!GetComponent<player_movement>().IsInvincible){
            if(Player_Direction==-1)ownufo=ufoname[0];
            else ownufo=ufoname[1];
            lifeValue -= 1f;
            GetComponent<player_movement>().IsInvincible=true;
            if(lifeValue > 0) respawnposition();
            else SceneManager.LoadScene(respawn);
        }
        
    }
    public void Ghost_ablitity(){
        if(Input.GetKeyDown("e"))teleport(GetComponent<player_movement>().facewh);
    }
    public void Robert_ablitity(){
        lifeValue++;
    }
    /*public void player_ablitity(){

    }*/
    void Update()
    {
        if(name=="Ghost")Ghost_ablitity();
    }

    void FixedUpdate(){

    }
    public void teleport(float facewh){
        transform.position += new Vector3(facewh, 0, 0)*15;
    }

}