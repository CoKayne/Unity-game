using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Win_Lost_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string winnerName = GameObject.Find("CharSave").GetComponent<CharSave>().win;
        string loserName = GameObject.Find("CharSave").GetComponent<CharSave>().loss;
        GameObject.Find("Winners").transform.Find(winnerName).gameObject.SetActive(true);
        GameObject.Find("Losers").transform.Find(loserName).gameObject.SetActive(true); 
        txt.GetComponent<TextMeshProUGUI>().text = winnerName;
    }
}
