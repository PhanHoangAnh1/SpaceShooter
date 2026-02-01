using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;

    // --- MỚI: Thêm dòng này để chỉnh vị trí bắn ---
    public Vector3 bulletOffset; 
    // ----------------------------------------------

    private float lastBulletTime;

    void Update()
    {
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
            // --- MỚI: Cộng thêm bulletOffset vào vị trí ---
            Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
            // ----------------------------------------------
        }
    }
}