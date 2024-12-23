using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Kecepatan pergerakan player
    private Vector2 moveDirection;
    private Rigidbody2D rb; // Komponen Rigidbody2D
    private ControlInput inputActions; // Referensi ke input control
    private Camera mainCamera; // Kamera utama

    private void Awake()
    {
        inputActions = new ControlInput();
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        // Dapatkan input dari sistem InputActions
        moveDirection = inputActions.Gameplay.Movement.ReadValue<Vector2>();

        // Gerakkan player
        Vector3 move = new Vector3(moveDirection.x, moveDirection.y, 0) * speed * Time.deltaTime;
        transform.position += move;

        // Cegah rotasi player (selalu menghadap depan)
        transform.rotation = Quaternion.identity;
        ClampPlayerPosition();
    }

    private void ClampPlayerPosition()
    {
        // Ambil posisi player di dunia
        Vector3 playerPosition = transform.position;

        // Konversi posisi ke viewport space (0,0 - 1,1)
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(playerPosition);

        // Membatasi agar posisi tetap dalam kamera
        viewportPosition.x = Mathf.Clamp(viewportPosition.x, 0f, 1f);
        viewportPosition.y = Mathf.Clamp(viewportPosition.y, 0f, 1f);

        // Konversi kembali ke posisi dunia
        transform.position = mainCamera.ViewportToWorldPoint(viewportPosition);
    }
}
