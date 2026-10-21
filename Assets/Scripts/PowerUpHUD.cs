using UnityEngine;
using TMPro; 

public class PowerUpHUD : MonoBehaviour
{

    [SerializeField] private PlayerPowerUps playerPowerUps;
    [SerializeField] private GameObject speedBoostIcon; // icon + time
    [SerializeField] private GameObject jumpBoostIcon; // icon + time
    [SerializeField] private GameObject scoreBoostIcon; // icon + time
    [SerializeField] private TMP_Text speedBoostText;
    [SerializeField] private TMP_Text jumpBoostText;
    [SerializeField] private TMP_Text scoreBoostText;
    
    // Update is called once per frame
    void Update()
    {
        float speedBoostTimeLeft = playerPowerUps.SpeedTimeLeft;
        float jumpBoostTimeLeft = playerPowerUps.JumpTimeLeft;
        float scoreBoostTimeLeft = playerPowerUps.ScoreTimeLeft;

        speedBoostIcon.SetActive(speedBoostTimeLeft > 0f);
        jumpBoostIcon.SetActive(jumpBoostTimeLeft > 0f);
        scoreBoostIcon.SetActive(scoreBoostTimeLeft > 0f);

        speedBoostText.text = Mathf.CeilToInt(speedBoostTimeLeft) + "s";
        jumpBoostText.text = Mathf.CeilToInt(jumpBoostTimeLeft) + "s";
        scoreBoostText.text = Mathf.CeilToInt(scoreBoostTimeLeft) + "s";
    }
}
