using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VIctoryMenu : MonoBehaviour
{
    public void PlayGame(){
        StartCoroutine(DoChangeScene("Game", .1f));
    }
    
    public void backToMain(){
        StartCoroutine(DoChangeScene("Main_menu", .1f));
    }
    IEnumerator DoChangeScene(string sceneToChangeTo, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
