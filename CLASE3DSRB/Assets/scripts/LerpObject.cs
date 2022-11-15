using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpObject : MonoBehaviour
{
	public Transform objectToMove;

	public Transform initialPos, finalPos;

	public float timeToLerp = 5;
	private float elalapsedTime = 0;

	public AnimationCurve lerpCurve;

	private void Update()
	{
		elalapsedTime += Time.deltaTime;
		float lerpPercentage = elalapsedTime / timeToLerp;

		objectToMove.position = Vector3.Lerp(initialPos.position, finalPos.position, lerpCurve.Evaluate(lerpPercentage));

		if (elalapsedTime > timeToLerp)
		{
			elalapsedTime = 0;
			Swap();
		}
	}

	public void Swap()
	{
		Transform temp = initialPos;
		initialPos = finalPos;
		finalPos = temp;
	}
}