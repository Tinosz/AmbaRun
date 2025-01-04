using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScButtonPause : MonoBehaviour
{
    public void tombolPause_click() {
        SceneManager.LoadScene("Pause");
    }
}

