using UnityEngine;

// Gives the player a speed boost for a limited time.
public class PlayerPowerUps : MonoBehaviour
{
    [SerializeField] private float boostMultiplier = 1.5f; // 50% faster
    [SerializeField] private float scoreBoostMultiplier = 2f;

    // Seconds of boost left. The HUD reads it; only this script changes it.
    public float SpeedTimeLeft { get; private set; }
    public float ScoreTimeLeft { get; private set; }
    public float JumpTimeLeft { get; private set; }

    public float ScoreMultiplier { get; private set; } = 1f;

    private CharacterMovement movement;

    private void Start()
    {
        movement = GetComponent<CharacterMovement>();
    }

    // Called by the pickup. Collecting another boost restarts the timer.
    public void ActivateSpeedBoost(float duration)
    {
        SpeedTimeLeft = duration;
        movement.SpeedMultiplier = boostMultiplier;
    }

    public void ActivateScoreBoost(float duration)
    {
        ScoreTimeLeft = duration;
        ScoreMultiplier = scoreBoostMultiplier;
    }

    public void ActivateJumpBoost(float duration)
    {
        JumpTimeLeft = duration;
        movement.DoubleJumpEnabled = true;
    }

    private void Update()
    {
        if (SpeedTimeLeft > 0f)
        {
            SpeedTimeLeft -= Time.deltaTime;

            if (SpeedTimeLeft <= 0f)
            {
                movement.SpeedMultiplier = 1f; // back to normal speed
            }
        }

        if (ScoreTimeLeft > 0f)
        {
            ScoreTimeLeft -= Time.deltaTime;

            if (ScoreTimeLeft <= 0f)
            {
                ScoreMultiplier = 1f;
            }
        }

        if (JumpTimeLeft > 0f)
        {
            JumpTimeLeft -= Time.deltaTime;

            if (JumpTimeLeft <= 0f)
            {
                movement.DoubleJumpEnabled = false;
            }
        }
    }
}