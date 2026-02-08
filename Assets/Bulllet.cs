using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float liveTime = 2f;
    
    // --- MỚI: Chỉ số sát thương của đạn ---
    public int damage = 1; 
    // --------------------------------------

    void Start()
    {
        // Hủy đạn sau một thời gian nếu không trúng gì
        Destroy(gameObject, liveTime);
    }

    void Update()
    {
        // Di chuyển đạn bay lên
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra va chạm với Enemy
        if (other.CompareTag("Enemy"))
        {
            // --- MỚI: TÌM VÀ TRỪ MÁU KẺ ĐỊCH ---
            
            // 1. Lấy script EnemyHealth từ đối tượng bị bắn trúng
            // Lưu ý: Đảm bảo kẻ địch đã gắn script "EnemyHealth"
            EnemyHealth enemy = other.GetComponent<EnemyHealth>();

            // 2. Nếu tìm thấy script máu thì trừ máu
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            // ------------------------------------

            // 3. Phá hủy viên đạn sau khi trúng đích
            Destroy(gameObject); 
        }
    }
}