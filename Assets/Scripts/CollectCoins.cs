using UnityEngine;

public class CollectCoins : MonoBehaviour
{

    private int score = 0;

    void OnTriggerEnter(Collider other)
{
    MasterInfo.cointCount += 1;
    
        AudioClip coinClip = Resources.Load<AudioClip>("Coins_Single_19");
        
        if (coinClip != null)
        {
            AudioSource.PlayClipAtPoint(coinClip, transform.position);
        }
        else
        {
            Debug.LogWarning("CoinCollect19 audio clip not found!");
        }
    
    this.gameObject.SetActive(false);
}



    public int GetScore(){
        return score;
    }
}
