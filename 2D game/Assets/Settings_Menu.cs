using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Settings_Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void quitSetttings(){
        SceneManager.LoadScene("Main_menu");
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
