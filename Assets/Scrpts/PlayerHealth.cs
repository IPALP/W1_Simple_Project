using NUnit.Framework;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBar;
    public GameUI gameUI;
    public int maxHealth = 100;
    int currentHealth;
    bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int amount)
    {
        if(isDead) return;

        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            isDead = true;
            gameUI.EndGame();
        }
    }
    public void Heal(int amount)
    {
        if(isDead)
            return;
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        healthBar.SetHealth(currentHealth);
    }
}
