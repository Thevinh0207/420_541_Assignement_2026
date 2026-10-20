using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    [SerializeField] private string nextScene = "level2Scene";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.SaveFinalScore();
            SceneManager.LoadScene(nextScene);
        }
    }
}