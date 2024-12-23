using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject gameOverPanel; // Panel Game Over

    private bool isGameOver = false;

    // Method untuk memunculkan Game Over
    public void TriggerGameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            gameOverPanel.SetActive(true); // Aktifkan Panel Game Over
            Time.timeScale = 0f; // Pause game
            // Debug.Log("Game Over! Player health reached 0.");
        }
    }
}
