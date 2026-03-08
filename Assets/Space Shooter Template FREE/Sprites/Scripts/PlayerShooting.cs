using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;
    public Vector3 bulletOffset; 

    private float lastBulletTime;
    
    // --- MỚI: Biến để lưu trữ cái loa (AudioSource) ---
    private AudioSource audioSource; 
    // --------------------------------------------------

    void Start()
    {
        // --- MỚI: Lấy component AudioSource đã gắn trên Player ---
        audioSource = GetComponent<AudioSource>();
        // ---------------------------------------------------------
    }

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
            Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
            
            // --- MỚI: Phát âm thanh bắn ---
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
            // -------------------------------
        }
    }
}