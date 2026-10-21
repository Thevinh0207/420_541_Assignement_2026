using UnityEngine;


// A coin that adds points to the score when the player touches it.
// Needs a collider with Is Trigger ticked on the same GameObject.
public class ScorePickup : MonoBehaviour
{
    // How many points this coin is worth (change it in the Inspector)
[SerializeField] private int points = 50;

private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        float multiplier = other.GetComponent<PlayerPowerUps>().ScoreMultiplier;
        GameManager.Instance.AddScore(Mathf.RoundToInt(points * multiplier));

        Destroy(gameObject);
    }
}
}
