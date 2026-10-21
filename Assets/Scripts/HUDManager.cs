using UnityEngine;
using TMPro;
public class HUDManager : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] private TMP_Text scoreText;

    [Header("Health")]
    [SerializeField] private TMP_Text healthText;

    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = FindAnyObjectByType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        UpdateHealth();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + GameManager.Instance.Score;
    }

    private void UpdateHealth()
    {
        healthText.text = "Health: " + playerHealth.Health;
    }
}
