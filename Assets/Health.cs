using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; 
    public int defaultHealthPoint;     
    protected int healthPoint; // (Đã đổi thành protected để class con nhìn thấy)

    private void Start() => healthPoint = defaultHealthPoint;

    public virtual void TakeDamage(int damage) // (Đã thêm virtual)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    protected virtual void Die() // (Đã có virtual)
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); 
        }
        Destroy(gameObject); 
    }
}