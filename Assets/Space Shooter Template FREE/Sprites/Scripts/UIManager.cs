using UnityEngine;
using UnityEngine.SceneManagement; // Để load lại màn chơi

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true); // Hiện bảng Game Over
    }

    public void ReplayGame()
    {
        // Load lại màn hình hiện tại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}