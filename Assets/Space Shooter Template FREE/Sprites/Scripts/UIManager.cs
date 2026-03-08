using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    // --- MỚI: Thêm biến chứa bảng Win ---
    public GameObject winPanel; 

    public void ShowGameOver()
    {
        if (gameOverPanel != null) gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Dừng thời gian khi thua
    }

    // --- MỚI: Hàm hiện bảng Thắng ---
    public void ShowGameWin()
    {
        if (winPanel != null) winPanel.SetActive(true);
        Time.timeScale = 0f; // Dừng thời gian khi thắng
    }

    public void ReplayGame()
    {
        Time.timeScale = 1f; // Trả lại thời gian bình thường trước khi chơi lại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}