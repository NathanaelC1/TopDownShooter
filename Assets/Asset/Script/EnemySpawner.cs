using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab musuh
    public float spawnInterval = 2f; // Waktu antar spawn
    public float spawnRangeX = 8f; // Jarak horizontal untuk spawn

    private float cameraTop; // Batas atas kamera

    private void Start()
    {
        cameraTop = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1f, 0f)).y; // Batas atas kamera
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    private void SpawnEnemy()
    {
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX); // Posisi X acak
        Vector3 spawnPosition = new Vector3(spawnX, cameraTop, 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
