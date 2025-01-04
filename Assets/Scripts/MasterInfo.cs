using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int cointCount = 0;
    [SerializeField] GameObject coinDisplay;

    void Start()
    {
        // Reset the coin count when the game starts
        cointCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + cointCount;
        GameData.totalCoins = cointCount; // Store the coin count in GameData
    }
}
