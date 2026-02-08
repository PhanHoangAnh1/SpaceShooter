using UnityEngine;

public class PlayerHealth : Health // Kế thừa từ class Health bạn đã viết
{
    // Ghi đè hàm Die để xử lý riêng cho Player
    protected override void Die()
    {
        base.Die(); // Gọi logic nổ mặc định (tạo hiệu ứng nổ)
        
        Debug.Log("GAME OVER!"); 
        // Sau này bạn sẽ thêm code hiện bảng Game Over ở đây
        // Ví dụ: UIManager.instance.ShowGameOver();
    }
}