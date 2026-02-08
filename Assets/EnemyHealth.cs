using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy died");
        // Có thể thêm logic tăng điểm số ở đây
    }
}