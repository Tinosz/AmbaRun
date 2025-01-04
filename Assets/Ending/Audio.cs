using UnityEngine;

public class Audio : MonoBehaviour
{
    public Canvas uiCanvas;  // Reference to your Canvas
    private AudioSource audioSource;  // Reference to the Audio Source component

    void Start()
    {
        // Get the Audio Source component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if the Canvas is active, and play music if it is
        if (uiCanvas.gameObject.activeSelf)
        {
            PlayMusic();
        }
    }

    // Method to play the music
    void PlayMusic()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}

