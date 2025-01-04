using UnityEngine;

public class Pausegame : MonoBehaviour
{
    private bool isPaused = false; // Track whether the game is paused

    public GameObject pauseMenu; // Reference to the pause menu UI (optional)

    public void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f; // Freeze game time
        isPaused = true;

        // Enable pause menu if assigned
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume game time
        isPaused = false;

        // Disable pause menu if assigned
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
    }
}
