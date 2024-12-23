using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab koin yang akan muncul

    public void Drop(Vector3 position)
    {
        // Tentukan jumlah koin yang akan dijatuhkan
        int coinCount = 1;

        // Tentukan posisi spawn koin secara acak di sekitar musuh
        Vector3 spawnPosition = position + new Vector3(
            Random.Range(-0.5f, 0.5f), // Posisi horizontal acak
            Random.Range(-0.5f, 0.5f), // Posisi vertikal acak
            0f // Z-axis tetap 0 untuk game 2D
        );

        // Instansiasi koin di posisi yang sudah ditentukan
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
