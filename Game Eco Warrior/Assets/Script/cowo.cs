using UnityEngine;

public class CharacterWithTrashBin : MonoBehaviour
{
    public float speed = 5f;       // Kecepatan karakter
    public float leftBoundary = -7f; // Batas kiri
    public float rightBoundary = 7f; // Batas kanan

    void Update()
    {
        // Gerakkan karakter dengan input horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        position.x += horizontalInput * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, leftBoundary, rightBoundary);
        transform.position = position;
    }

    // Deteksi jika ada objek sampah yang masuk ke keranjang
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Cek apakah objek yang terkena adalah sampah berdasarkan layer atau tag
        if (other.gameObject.layer == LayerMask.NameToLayer("Trash")) // atau other.CompareTag("Trash")
        {
            // Hapus sampah saat tertangkap
            Destroy(other.gameObject);
        }
    }
}