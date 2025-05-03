using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public float maxHealth = 10000f;
    public float currentHealth;

    public Slider healthBar;

    public string endSceneName = "End Credit";

    void Start()
    {
        currentHealth = maxHealth;
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth; // << �Ӥѭ
            healthBar.value = currentHealth;
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHealthBar()
    {
        if (healthBar != null)
            healthBar.value = currentHealth;
    }

    void Die()
    {
        if (Application.CanStreamedLevelBeLoaded(endSceneName))
        {
            SceneManager.LoadScene(endSceneName);
        }
        else
        {
            Debug.LogError("End scene not found in Build Settings!");
        }
    }
}
