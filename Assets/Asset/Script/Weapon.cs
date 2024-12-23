using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab peluru
    public Transform bulletSpawnPoint; // Posisi peluncuran peluru
    public float fireRate = 2f; // Jumlah tembakan per detik

    private float nextFireTime = 0f; // Waktu berikutnya untuk menembak

    private void Update()
    {
        // Cek apakah waktu saat ini melewati waktu berikutnya untuk menembak
        if (Time.time >= nextFireTime)
        {
            Fire(); // Panggil fungsi Fire untuk menembakkan peluru
            nextFireTime = Time.time + (1f / fireRate); // Hitung waktu tembakan berikutnya
        }
    }

    private void Fire()
    {
        // Instansiasi peluru di posisi dan rotasi spawn point
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
