using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
	public GameObject grenadePrefab;
	public Transform MyCamera;

	public float throwForce;

	private void Update()
	{
		if (Input.GetButtonDown("Fire2"))
		{
			ThrowGrenade();
		}
	}

	private void ThrowGrenade()
	{
		GameObject grenade = Instantiate(grenadePrefab, MyCamera.position, Quaternion.identity);

		Rigidbody rb = grenade.GetComponent<Rigidbody>();

		rb.AddForce(MyCamera.forward * throwForce, ForceMode.Impulse);
	}
}