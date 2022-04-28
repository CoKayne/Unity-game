using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Char_selectMenu : MonoBehaviour
{
    public void PlayGame(){
        StartCoroutine(DoChangeScene("Game", .1f));
    }
    IEnumerator DoChangeScene(string sceneToChangeTo, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToChangeTo);
    }

    void Update(){
        bool p1s = GameObject.Find("Select_control").GetComponent<selection_control>().player1Selected;
        bool p2s = GameObject.Find("Select_control").GetComponent<selection_control>().player2Selected;
        if(Input.GetKeyDown("space") && p1s && p2s){
            SoundManagerScript.PlaySound("jump");
            PlayGame();
        }
    }

}
