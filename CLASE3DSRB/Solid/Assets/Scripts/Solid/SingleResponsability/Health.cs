using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private void Start()
    {
        currentHealth = MaxHealth;
    }

    public void takeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
    }

    private void Update()
    {
    }
}