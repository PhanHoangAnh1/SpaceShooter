using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Giữ nguyên tên class là PlayerShooting để khớp với tên file
public class PlayerShooting : MonoBehaviour
{
    // Đổi tên biến thành 'bulletPrefab' cho dễ hiểu giống tutorial
    public GameObject bulletPrefab;
    
    // Tốc độ bắn
    public float shootingInterval = 0.2f;
    
    private float lastBulletTime;

    void Update()
    {
        // Nếu nhấn chuột trái (0)
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                Shoot();
                lastBulletTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}