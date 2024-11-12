using UnityEngine;

public class FalingTrash : MonoBehaviour
{
    public float fallSpeed = 5f; // Kecepatan jatuhnya sampah

    void Update()
    {
        // Membuat sampah jatuh ke bawah
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }

    // Ketika sampah bertemu dengan keranjang atau karakter, sampah akan hilang
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Periksa apakah objek yang disentuh memiliki tag "TrashBin" atau "Player"
        if (other.CompareTag("TrashBin") || other.CompareTag("Player")) // Pastikan keranjang dan karakter memiliki tag yang sesuai
        {
            // Destroy sampah agar hilang
            Destroy(gameObject);

            // Jika ingin menambahkan efek suara atau skor, lakukan di sini
            Debug.Log("Sampah berhasil tertangkap!");
        }
    }
}