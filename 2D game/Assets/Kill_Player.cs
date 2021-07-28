using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Player     : MonoBehaviour
{
    public int respawn;
    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            SceneManager.LoadScene(respawn);
        }
    }
}
 