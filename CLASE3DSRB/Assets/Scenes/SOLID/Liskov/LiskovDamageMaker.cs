using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiskovDamageMaker : MonoBehaviour
{
    public int DamageToMake;

    private void OnTriggerEnter(Collider other)
    {
        LiskovHealth health = other.gameObject.GetComponent<LiskovHealth>();

        health.TakeDamage(DamageToMake);
    }
}