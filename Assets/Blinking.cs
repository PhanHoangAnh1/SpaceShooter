using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    // Khai báo biến để chứa SpriteRenderer (thành phần hiển thị hình ảnh)
    private SpriteRenderer spriteRenderer;

    // Start được gọi 1 lần khi bắt đầu game
    void Start()
    {
        // Lấy thành phần SpriteRenderer đang gắn trên đối tượng này
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update được gọi liên tục mỗi khung hình
    void Update()
    {
        // Đảo ngược trạng thái hiển thị (Đang hiện -> Ẩn, Đang ẩn -> Hiện)
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}