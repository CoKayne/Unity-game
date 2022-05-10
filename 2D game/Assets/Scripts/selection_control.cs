using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection_control : MonoBehaviour
{
    // Update is called once per frame
    public GameObject ready1;
    public GameObject ready2;
    public GameObject startButton;
    public bool player1Selected = false;
    public bool player2Selected = false;
    void Update()
    {
        //player 1 select
        if (Input.GetKeyDown("d") && player1Selected == false)
        {
            GameObject.Find("Characters1").GetComponent<Character_selection>().NextCharacter();
            SoundManagerScript.PlaySound("click2");
        }
        else if (Input.GetKeyDown("a") && player1Selected == false)
        {
            GameObject.Find("Characters1").GetComponent<Character_selection>().PreviousCharacter();
            SoundManagerScript.PlaySound("click2");
        }
        else if (Input.GetKeyDown("s") && player1Selected == false)
        {
            SoundManagerScript.PlaySound("click");
            ready1.SetActive(true);
            int player1Char = GameObject.Find("Characters1").GetComponent<Character_selection>().selectedChar;
            GameObject.Find("Characters1").GetComponent<Character_selection>().selectCompleteLeft(player1Char);
            GameObject.Find("Characters2").GetComponent<Character_selection>().removeCharacter(player1Char);
            player1Selected = true; 
        }

        //player 2 select
        if (Input.GetKeyDown("l") && player2Selected == false)
        {
            GameObject.Find("Characters2").GetComponent<Character_selection>().NextCharacter();
            SoundManagerScript.PlaySound("click2");
        }
        else if (Input.GetKeyDown("j") && player2Selected == false)
        {
            GameObject.Find("Characters2").GetComponent<Character_selection>().PreviousCharacter();
            SoundManagerScript.PlaySound("click2");
        }
        else if (Input.GetKeyDown("k") && player2Selected == false)
        {
            SoundManagerScript.PlaySound("click");
            ready2.SetActive(true);
            int player2Char = GameObject.Find("Characters2").GetComponent<Character_selection>().selectedChar;
            GameObject.Find("Characters2").GetComponent<Character_selection>().selectCompleteRight(player2Char);
            GameObject.Find("Characters1").GetComponent<Character_selection>().removeCharacter(player2Char);
            player2Selected = true;
        }

        if (player1Selected == true && player2Selected == true)
        {
            startButton.SetActive(true);
        }
    }
}
