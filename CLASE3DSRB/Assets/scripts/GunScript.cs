using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
	public Transform MyCamera;

	public float range = 100f;

	public GameObject bulletImpactPrefab;

	public float impactForce = 40f;

	public int damageDealt = 1;

	private void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}

	private void Shoot()
	{
		RaycastHit hitInfo;

		if (Physics.Raycast(MyCamera.position, MyCamera.forward, out hitInfo, range))
		{
			GameObject bulletImpact = Instantiate(bulletImpactPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
			Destroy(bulletImpact, 2);

			Rigidbody rb = hitInfo.collider.gameObject.GetComponent<Rigidbody>();

			if (rb != null)
			{
				rb.AddForce(-hitInfo.normal * impactForce, ForceMode.Impulse);
			}

			Health health = hitInfo.collider.gameObject.GetComponent<Health>();
			if (health != null)
			{
				health.TakeDamage(damageDealt);
			}
		}
		else
		{
			Debug.Log("no le he dado a nada");
		}
	}
}