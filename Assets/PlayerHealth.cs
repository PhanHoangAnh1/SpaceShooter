using UnityEngine;

public class PlayerHealth : Health 
{
    protected override void Die()
    {
        base.Die(); // Tạo hiệu ứng nổ và biến mất

        // --- MỚI: Gọi bảng Game Over hiện lên ---
        // Chúng ta tìm script UIManager trong cảnh và bảo nó chạy hàm ShowGameOver
        UIManager ui = FindObjectOfType<UIManager>();
        if (ui != null)
        {
            ui.ShowGameOver();
        }
        
        Debug.Log("GAME OVER!"); 
    }
}