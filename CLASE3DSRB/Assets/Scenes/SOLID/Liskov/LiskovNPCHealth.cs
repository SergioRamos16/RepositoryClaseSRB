using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiskovNPCHealth : LiskovHealth
{
    public override void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount * 5;
    }
}