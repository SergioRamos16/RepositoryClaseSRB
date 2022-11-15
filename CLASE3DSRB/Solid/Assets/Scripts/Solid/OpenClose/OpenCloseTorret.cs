using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseTorret : MonoBehaviour

{
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public GameObject misilPrefab;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    private void Fire()
    {
        if (bulletPrefab != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            OpenCloseProjectil projectil = bullet.GetComponent<OpenCloseProjectil>();
            if (projectil != null)
            {
                projectil.ShootProjectile(shootPoint.forward);
            }
        }
    }
}