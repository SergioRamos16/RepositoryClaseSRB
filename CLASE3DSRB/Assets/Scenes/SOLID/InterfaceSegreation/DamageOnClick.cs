using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnClick : MonoBehaviour
{
    public int damageAmount = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                IDamageable damageable = hitInfo.collider.GetComponent<IDamageable>();
                damageable.TakeDamage(damageAmount);
            }
        }
    }
}