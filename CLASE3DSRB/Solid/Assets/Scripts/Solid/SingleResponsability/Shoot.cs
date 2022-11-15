using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject proyectilePrefab;

    public Transform shootPosition;

    public float shootForce = 30;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        GameObject bullet = Instantiate(proyectilePrefab, shootPosition.position, shootPosition.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPosition.forward * shootForce, ForceMode.Impulse);
        }
    }
}