using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_control : MonoBehaviour
{
    public string[] playerName;
    public string left;
    public string right;

    // Start is called before the first frame update
    void Start()
    {
        left = GameObject.Find("CharSave").GetComponent<CharSave>().pl1;
        right = GameObject.Find("CharSave").GetComponent<CharSave>().pl2;
        GameObject.Find(left).GetComponent<player_info>().setleft();
        GameObject.Find(right).GetComponent<player_info>().setright();
    }
    IEnumerator DoChangeScene(string sceneToChangeTo, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void whowin(int n)
    {
        if (n == -1)
        {
            setwin(left);
            setloss(right);
        }
        else if (n == 1)
        {
            setwin(right);
            setloss(left);
        }
        StartCoroutine(DoChangeScene("Victory", .1f));
    }

    // Update is called once per frame
    public void setwin(string s)
    {
        GameObject.Find("CharSave").GetComponent<CharSave>().win = s;
    }
    public void setloss(string s)
    {
        GameObject.Find("CharSave").GetComponent<CharSave>().loss = s;
    }
    void Update()
    {
        Debug.Log(left);
        Debug.Log(right);
    }
}