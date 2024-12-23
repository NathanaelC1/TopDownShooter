using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    public float speed = 2f; // Kecepatan scrolling
    public float resetPositionY; // Posisi Y untuk mereset background
    public float startPositionY; // Posisi Y awal background

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= resetPositionY)
        {
            Vector3 newPos = transform.position;
            newPos.y = startPositionY;
            transform.position = newPos;
        }
    }
}
