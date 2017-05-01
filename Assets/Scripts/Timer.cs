using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    int timeleft;
    private Text timeText;
    // Use this for initialization

    private void Awake()
    {
        timeText = GameObject.Find("Text").GetComponent<Text>();
    }

    void Start () {
        timeleft = 5500;
	}
	
	// Update is called once per frame
	void Update () {
        timeleft = timeleft - 1;

        if (timeleft <= 0){
            SceneManager.LoadScene("WinScene");
        }
        timeText.text = "Time Left: " + timeleft;
	}
}
