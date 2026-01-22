using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Tốc độ bay của đạn (bạn có thể chỉnh số này trong Unity sau)
    public float speed = 10f;

    void Update()
    {
        // 1. Lấy vị trí hiện tại của viên đạn
        Vector3 temp = transform.position;

        // 2. Cộng thêm vào trục Y (để bay lên trên)
        // Time.deltaTime giúp đạn bay mượt mà trên mọi máy
        temp.y += speed * Time.deltaTime;

        // 3. Gán vị trí mới cho viên đạn
        transform.position = temp;
    }
}