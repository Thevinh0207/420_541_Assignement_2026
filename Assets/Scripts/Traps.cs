using UnityEngine;

public class Traps : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
        if (health == null) return;

        health.TakeDamage(damage);
    }
}