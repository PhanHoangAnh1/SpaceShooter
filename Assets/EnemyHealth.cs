using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy died");
        
        // --- LOGIC TĂNG ĐIỂM ---
        GameManager gm = FindObjectOfType<GameManager>();
        if (gm != null)
        {
            gm.AddScore(1); // Cộng 1 điểm mỗi khi Enemy này nổ
        }
        // -----------------------
    }
}