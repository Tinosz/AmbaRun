using UnityEngine;
using TMPro;

public class DeathScreenUI : MonoBehaviour
{
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI coinsText;

    void Start()
    {
        // Retrieve and display the total distance and coins
        distanceText.text = "Distance: " + Mathf.FloorToInt(GameData.totalDistance) + "s";
        coinsText.text = "Coins: " + GameData.totalCoins;
    }
}
