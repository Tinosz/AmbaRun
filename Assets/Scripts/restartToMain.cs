using UnityEngine;
using UnityEngine.SceneManagement;

public class restartToMain : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("SceneUAS");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Opening");
    }
}
