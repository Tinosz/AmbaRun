using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScPlay : MonoBehaviour
{
    public void tombolStart_click() {
        SceneManager.LoadScene("SceneUAS");
    }

    public void tombolExit_click() {
        Debug.Log("Game is exiting...");

        #if UNITY_EDITOR
        // If running in the Unity Editor, stop Play Mode
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // If running as a standalone build, quit the application
        Application.Quit();
        #endif
    }

    private void ResetGameData()
    {
        GameData.totalCoins = 0;
        GameData.totalDistance = 0f;
    }
}
