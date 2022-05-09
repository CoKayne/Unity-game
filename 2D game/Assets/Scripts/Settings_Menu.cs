using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Settings_Menu : MonoBehaviour
{
    public Animator transition;
    public float transTime;
    public AudioMixer audioMixer;
    public void quitSetttings(){
        StartCoroutine(DoChangeScene("Main_menu", transTime));
    }
    IEnumerator DoChangeScene(string sceneToChangeTo, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToChangeTo);
    }
    public void setVolume(float volume){
        audioMixer.SetFloat("Volume", volume);
    }
    public void setQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex + 3);
    }

    public void setFullscreen(bool isFullscreen){
        Screen.fullScreen = isFullscreen;
    }

}