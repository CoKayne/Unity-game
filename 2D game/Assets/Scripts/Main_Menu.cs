using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public Animator transition;
    public float transTime;
    public void PlayGame(){
        StartCoroutine(DoChangeScene("Game", transTime));
    }
    public void openSelectMenu(){
        StartCoroutine(DoChangeScene("Char_selection", transTime));
    }
    public void openSettings(){
        StartCoroutine(DoChangeScene("Settings_menu", transTime));
    }
    IEnumerator DoChangeScene(string sceneToChangeTo, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }

}