using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public float speed = 5f; // Kecepatan peluru musuh
    public float lifetime = 5f; // Waktu hidup peluru musuh

    private void Start()
    {
        Destroy(gameObject, lifetime); // Hancurkan peluru setelah beberapa detik
    }

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); // Gerakan lurus ke bawah
    }
}
