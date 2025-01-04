using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    public float playerSpeed = 8f;
    public float horizontalSpeed = 3f;

    // Peningkatan kecepatan
    public float speedIncreaseRate = 0.3f;

    // Offset batas kiri dan kanan relatif terhadap posisi awal
    public float rightLimitOffset = 3.5f;
    public float leftLimitOffset = -3.5f;

    private float rightLimit;
    private float leftLimit;

    public Vector3 startPosition = new Vector3(1.36f, 10.57f, -48.72f);

    void Start()
    {
        transform.position = startPosition;

        rightLimit = startPosition.x + rightLimitOffset;
        leftLimit = startPosition.x + leftLimitOffset;
    }

    void Update()
    {
        // Tingkatkan kecepatan pemain seiring waktu
        playerSpeed += speedIncreaseRate * Time.deltaTime;

        // Gerakan maju
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);

        // Gerakan ke kiri
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }

        // Gerakan ke kanan
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("UIAMBA");
            this.enabled = false;

            playerSpeed = 0f;
            speedIncreaseRate = 0f;
        }

        // Load Pause when pressing Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Pause");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("obstacle"))
        {
            this.enabled = false;

            playerSpeed = 0f;
            speedIncreaseRate = 0f;

            Debug.Log("Player hit an obstacle: " + other.gameObject.name);
            SceneManager.LoadScene("UIAMBA");
        }
    }

}
