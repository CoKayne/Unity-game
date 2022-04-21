using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_selection : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> characters;
    public List<GameObject> charactersTMP;
    public int selectedChar = 0; 
    public int player1Char;
    public int player2Char;
    public void NextCharacter(){
        characters[selectedChar].SetActive(false);
        selectedChar = (selectedChar + 1 ) % characters.Count;
        characters[selectedChar].SetActive(true);
    } 
    public void PreviousCharacter(){
        characters[selectedChar].SetActive(false);
        selectedChar--;
        if(selectedChar < 0){
            selectedChar += characters.Count;
        }
        characters[selectedChar].SetActive(true);
    }
    public void removeCharacter(int target){
        bool player1Selected = GameObject.Find("Select_control").GetComponent<selection_control>().player1Selected;
        bool player2Selected = GameObject.Find("Select_control").GetComponent<selection_control>().player2Selected;
        Destroy(characters[target]);
        characters.RemoveAt(target);
        if(!player1Selected && !player2Selected){
            characters[0].SetActive(true);
            selectedChar = 0;
        }
    }

}
