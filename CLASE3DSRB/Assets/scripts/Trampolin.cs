using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : PlayerTrigger
{
	public float forceMagnitude = 15;

	public override void OnPlayerEnter(GameObject playerObject)
	{
		Rigidbody rb = playerObject.GetComponent<Rigidbody>();

		rb.AddForce(Vector3.up * forceMagnitude, ForceMode.Force);
	}
}