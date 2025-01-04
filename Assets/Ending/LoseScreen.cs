using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // For scene management

public class LoseScreen : MonoBehaviour
{
    public void tombolStart_click() {
        SceneManager.LoadScene("Scence_Awal");
    }
}
