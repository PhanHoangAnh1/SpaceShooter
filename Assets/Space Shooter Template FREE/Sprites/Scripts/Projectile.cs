using UnityEngine;

public class Projectile : MonoBehaviour {
    public int damage = 1;
    public bool enemyBullet; // Đạn của ai? (Tích = Địch, Không tích = Player)
    public bool destroyedByCollision = true;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // --- MÁY DÒ BẮT ĐẦU ---
        Debug.Log("Va chạm với: " + collision.gameObject.name + " | Tag: " + collision.tag);

        if (enemyBullet) 
        {
            // Logic cho đạn của Địch
            if (collision.CompareTag("Player"))
            {
                Debug.Log("Đạn địch trúng Player!");
                var player = collision.GetComponent<PlayerHealth>();
                if (player) player.TakeDamage(damage);
                if (destroyedByCollision) Destroy(gameObject);
            }
        }
        else 
        {
            // Logic cho đạn của Player (CHÚ Ý CHỖ NÀY)
            if (collision.CompareTag("Enemy"))
            {
                Debug.Log("Đạn Player trúng Enemy!"); // <-- Nếu dòng này hiện ra, logic đúng
                var enemy = collision.GetComponent<EnemyHealth>();
                
                if (enemy != null)
                {
                    Debug.Log("Đã tìm thấy script EnemyHealth -> Trừ máu!");
                    enemy.TakeDamage(damage);
                }
                else
                {
                    Debug.LogError("LỖI: Object có tag Enemy nhưng KHÔNG CÓ script EnemyHealth!");
                }

                if (destroyedByCollision) Destroy(gameObject);
            }
            else
            {
                Debug.Log("Đạn trúng cái gì đó không phải Enemy. Tag là: " + collision.tag);
            }
        }
    }
}