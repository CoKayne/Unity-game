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
        
    }
    public void setleft(){
       Player_Direction =- 1;
    }
    public void setright(){
       Player_Direction = 1;
    }

    public void respawnposition(){
       transform.position = new Vector3(33 * Player_Direction, 43, 0);
       GameObject.Find(ownufo).GetComponent<ufo_control>().respawn();
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Deadly_things")){
            if(Player_Direction==-1)ownufo=ufoname[0];
            else ownufo=ufoname[1];
            lifeValue -= 1f;
            if(lifeValue > 0) respawnposition();
            else SceneManager.LoadScene(respawn);
        }
        
    }
    void Update()
    {
        
    }

    void FixedUpdate(){

    }

}