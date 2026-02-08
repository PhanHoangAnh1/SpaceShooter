using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    private EnemyHealth myHealth;

    void Start()
    {
        myHealth = GetComponent<EnemyHealth>();
    }

    // Dùng cái này nếu Collider đang tích "Is Trigger"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enemy va chạm với cái gì đó: " + collision.gameObject.name); // <--- BẪY 1

        if (collision.CompareTag("Player"))
        {
            Debug.Log("--> Đúng là Player rồi! Tấn công thôi!"); // <--- BẪY 2

            var playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                Debug.Log("--> Đã trừ máu Player");
            }
            else
            {
                Debug.LogError("--> LỖI: Player không có script PlayerHealth!");
            }

            // Tự hủy Enemy
            if (myHealth != null) myHealth.TakeDamage(10000);
        }
    }
}