using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update chạy liên tục mỗi khung hình
    void Update()
    {
        // BƯỚC 16: Lấy vị trí chuột (Input.mousePosition)
        // BƯỚC 17: Chuyển từ tọa độ màn hình sang tọa độ thế giới game (World Point)
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Đặt độ sâu Z = 0 để tàu luôn nằm trên mặt phẳng 2D
        worldPoint.z = 0;

        // Cập nhật vị trí của tàu theo vị trí chuột
        transform.position = worldPoint;
    }
}