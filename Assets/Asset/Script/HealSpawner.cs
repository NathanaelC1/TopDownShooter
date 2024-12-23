using UnityEngine;

public class HealSpawner : MonoBehaviour
{
    public GameObject healPrefab;
    public float spawnInterval = 15f; // Interval spawn
    public float spawnRangeX = 8f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnHeal), spawnInterval, spawnInterval);
    }

    private void SpawnHeal()
    {
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnY = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1f, 0f)).y;
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
        Instantiate(healPrefab, spawnPosition, Quaternion.identity);
    }
}
