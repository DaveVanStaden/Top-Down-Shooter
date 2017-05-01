using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour {
    
    public void StartButton(string Startlevel)
    {
        SceneManager.LoadScene("Wereld");
    }
    public void RetryButton(string Retrylevel)
    {
        SceneManager.LoadScene("Wereld");
    }
}
