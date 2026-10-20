using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    [SerializeField] private float fallLimit = -10f;

    public int Health { get; private set; }
    public int MaxHealth => maxHealth;

    private void Start()
    {
        Health = maxHealth;
    }

    private void Update()
    {
        if (transform.position.y < fallLimit)
        {
            RestartLevel();
        }
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}