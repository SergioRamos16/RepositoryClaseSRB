using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
	public float a = 0;
	public float b = 10;

	public float timeToLerp = 5;
	private float timeElapsed = 0;

	public float lerpValue;

	private void Update()
	{
		timeElapsed += Time.deltaTime;
		float lerpPercentage = timeElapsed / timeToLerp;

		lerpValue = Mathf.Lerp(a, b, lerpPercentage);
	}
}