using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    [Header("GameOver Script Reference")]
    [SerializeField] private GameOver gameOver;

    public Image[] hearts; // Gambar hati di UI

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < currentHealth;
        }
    }

    private void Die()
    {
        Debug.Log("Player Died");
        // Tambahkan logika game over di sini
        Destroy(gameObject);
        gameOver.TriggerGameOver();
    }
}
