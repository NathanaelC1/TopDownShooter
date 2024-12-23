using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 10f; // Kecepatan peluru

    private void Update()
    {
        // Gerakkan peluru lurus berdasarkan arah rotasinya
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        // Hapus peluru jika keluar dari layar
        Destroy(gameObject);
    }
}
