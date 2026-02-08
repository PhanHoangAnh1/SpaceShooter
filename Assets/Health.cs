using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; // Prefab hiệu ứng nổ
    public int defaultHealthPoint;     // Máu mặc định
    private int healthPoint;

    private void Start() => healthPoint = defaultHealthPoint;

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ tại vị trí chết
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Hủy hiệu ứng nổ sau 1 giây
        }
        Destroy(gameObject); // Hủy đối tượng game
    }
}