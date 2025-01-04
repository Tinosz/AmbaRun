using UnityEngine;
using TMPro; // Required for TextMeshPro support

public class GameUIScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference for score display
    public TextMeshProUGUI timeSurvivedText; // Reference for time survived display

    private int score = 0; 
    private float timeSurvived = 0f;

    public CollectCoins collectCoins; // Reference to CollectCoins script

    void Start()
    {
        // Reset score and time survived at the start of the game
        timeSurvived = 0f;
        score = 0;
    }

    void Update()
    {
        // Update time survived
        timeSurvived += Time.deltaTime;

        if (collectCoins != null)
        {
            score = collectCoins.GetScore(); // Ensure CollectCoins has a method to get the score
        }

        // Update score and time survived texts
        scoreText.text = score.ToString(); // Display score
        timeSurvivedText.text = Mathf.FloorToInt(timeSurvived).ToString() + "s"; // Display time survived

        GameData.totalDistance = timeSurvived; // Store the distance in GameData
    }
}
