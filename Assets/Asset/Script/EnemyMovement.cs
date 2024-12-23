using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 direction;

    private void Start()
    {
        ChooseRandomDirection();
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        ClampPosition();
    }

    private void ChooseRandomDirection()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, -0.5f), 0f).normalized;
    }

    private void ClampPosition()
    {
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);
        
        // Cek batas kiri dan kanan
        if (viewportPosition.x <= 0f || viewportPosition.x >= 1f)
        {
            direction.x = -direction.x; // Balik arah horizontal
        }

        // Cek batas atas dan bawah
        if (viewportPosition.y <= 0f || viewportPosition.y >= 1f)
        {
            direction.y = -direction.y; // Balik arah vertikal
        }

        // Pastikan posisi tetap dalam batas viewport
        viewportPosition.x = Mathf.Clamp(viewportPosition.x, 0f, 1f);
        viewportPosition.y = Mathf.Clamp(viewportPosition.y, 0f, 1f);
        transform.position = Camera.main.ViewportToWorldPoint(viewportPosition);
    }
}