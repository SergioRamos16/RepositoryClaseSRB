using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
	public float rotationSpeedX, RotationSpeedY, RotationSpeedZ;

	// Update is called once per frame
	private void Update()
	{
		transform.Rotate(rotationSpeedX * Time.deltaTime, RotationSpeedY * Time.deltaTime,
			RotationSpeedZ * Time.deltaTime);
	}
}