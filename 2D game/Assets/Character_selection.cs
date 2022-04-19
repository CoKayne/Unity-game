using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_selection : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] characters;
    public int selectedChar = 0; 
    public void NextCharacter(){
        characters[selectedChar].SetActive(false);
        selectedChar = (selectedChar + 1 ) % characters.Length;
        characters[selectedChar].SetActive(true);
    }
    
    public void PreviousCharacter(){
        characters[selectedChar].SetActive(false);
        selectedChar--;
        if(selectedChar < 0){
            selectedChar += characters.Length;
        }
        characters[selectedChar].SetActive(true);
    }
}
