using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScPause : MonoBehaviour
{
    public void tombolRestart_click() {
        Debug.Log("Restart button clicked");
        SceneManager.LoadScene("SceneUAS");
    }

    public void tombolMenu_click() {
        SceneManager.LoadScene("Opening");
    }
}
