using UnityEngine;

public class PlayerCollectCoins : MonoBehaviour
{
    public ScoreCounter scoreCounter; // Referensi ke ScoreCounter

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            // Tambahkan skor
            if (scoreCounter != null)
            {
                scoreCounter.AddScore(1); // Tambahkan skor sebesar 1 (atau sesuai nilai)
            }

            Destroy(collision.gameObject); // Hancurkan koin setelah diambil
        }
    }
}
