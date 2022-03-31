using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public void PlayGame(){
        StartCoroutine(DoChangeScene("Game", .1f));
    }

    public void openSettings(){
        StartCoroutine(DoChangeScene("Settings_menu", .1f));
    }
    IEnumerator DoChangeScene(string sceneToChangeTo, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void QuitGame(){
        Debug.Log("QUIT!");
        // Application.Quit();
    }

}