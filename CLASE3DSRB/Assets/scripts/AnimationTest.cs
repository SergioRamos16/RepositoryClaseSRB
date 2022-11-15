using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
	public Animator myAnimator;

	private void Update()
	{
		if (Input.GetButtonDown("Jump"))
		{
			myAnimator.SetBool("OpenDoor", true);
		}

		if (Input.GetKeyDown(KeyCode.F))
		{
			myAnimator.SetBool("OpenDoor", false);
		}
	}
}