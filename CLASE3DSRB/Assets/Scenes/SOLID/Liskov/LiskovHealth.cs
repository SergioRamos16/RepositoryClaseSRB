using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiskovHealth : MonoBehaviour
{
    public float maxHealth = 10;
    protected float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
    }
}