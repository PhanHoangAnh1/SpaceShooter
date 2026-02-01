using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float liveTime = 2f;

    // --- MỚI 1: Biến chứa hiệu ứng nổ ---
    public GameObject explosionVFX; 
    // ------------------------------------

    void Start()
    {
        Destroy(gameObject, liveTime);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // --- MỚI 2: Tạo hiệu ứng nổ tại vị trí kẻ địch ---
            if (explosionVFX != null)
            {
                Instantiate(explosionVFX, transform.position, Quaternion.identity);
            }
            // -------------------------------------------------

            Destroy(other.gameObject); // Phá hủy địch
            Destroy(gameObject);       // Phá hủy đạn
        }
    }
}