using UnityEngine;
using TMPro;

public class PlayerHealth : Health
{
    public TextMeshProUGUI healthText;

    void Start()
    {
        UpdateHealthUI();
    }
    //
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "HP: " + healthPoint;
        }
    }

    protected override void Die()
    {
        base.Die();
        UIManager ui = FindObjectOfType<UIManager>();
        if (ui != null) ui.ShowGameOver();
    }
}