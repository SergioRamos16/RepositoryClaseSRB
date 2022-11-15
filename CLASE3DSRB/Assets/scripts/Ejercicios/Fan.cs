using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : PlayerTrigger
{
	public float forceMagnitude = 15;

	public override void OnPlayerStay(GameObject playerObject)
	{
		Rigidbody rg = playerObject.GetComponent<Rigidbody>();

		rg.AddForce(Vector3.up * forceMagnitude, ForceMode.Acceleration);
	}
}