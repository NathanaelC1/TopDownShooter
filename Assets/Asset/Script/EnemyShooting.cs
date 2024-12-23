using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab peluru musuh
    public Transform firePoint; // Titik spawn peluru
    public float bulletSpeed = 5f; // Kecepatan peluru
    public float fireRate = 1f; // Peluru per detik

    private float fireTimer; // Timer untuk jeda antara tembakan

    private void Update()
    {
        // Perbarui timer
        fireTimer += Time.deltaTime;

        // Tembak peluru jika waktunya sudah cukup
        if (fireTimer >= 1f / fireRate)
        {
            Shoot();
            fireTimer = 0f; // Reset timer
        }
    }

    private void Shoot()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("BulletPrefab atau FirePoint belum diatur!");
            return;
        }

        // Instansiasi peluru di posisi firePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // Beri peluru kecepatan untuk bergerak ke arah bawah (menuju player)
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.down * bulletSpeed;
        }
    }
}
