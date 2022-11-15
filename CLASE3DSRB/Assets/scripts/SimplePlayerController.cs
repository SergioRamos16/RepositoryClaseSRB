using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
	public float movementSpeed = 10;
	public float rotationSpeed = 90;

	private void Update()
	{
		float verticalInput = Input.GetAxis("Vertical");
		float horizontalInput = Input.GetAxis("Horizontal");

		transform.position += transform.forward * Time.deltaTime * movementSpeed * verticalInput;
		transform.Rotate(0, rotationSpeed * Time.deltaTime * horizontalInput, 0);
	}
}