using UnityEngine;

public class CollectableCoins : MonoBehaviour
{
    [SerializeField] int rotateSpeed = 1;

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        // Periksa apakah objek yang menyentuh koin adalah pemain
        if (other.CompareTag("NiggaBoy"))
        {
            // Hancurkan koin (hilangkan dari scene)
            Destroy(gameObject);
        }
    }
}
