using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Hàm Start chạy 1 lần duy nhất khi bắt đầu
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Hàm Update chạy liên tục mỗi khung hình (frame)
    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount);
    }
}