using UnityEngine;
using UnityEngine.UI; // Bắt buộc phải có dòng này để dùng UI Text

public class GameManager : MonoBehaviour
{
    public int scoreToWin = 10; // Số điểm cần để thắng (bạn có thể đổi)
    private int currentScore = 0;
    
    public Text scoreText; // Kéo ScoreText vào đây
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        UpdateScoreUI();
        Time.timeScale = 1f; // Đảm bảo thời gian trôi bình thường khi mới vào game
    }

    public void AddScore(int points)
    {
        currentScore += points;
        UpdateScoreUI();

        // Kiểm tra xem đã đủ điểm thắng chưa
        if (currentScore >= scoreToWin)
        {
            if (uiManager != null)
            {
                uiManager.ShowGameWin(); // Gọi hàm thắng game
            }
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "SCORE: " + currentScore;
        }
    }
}