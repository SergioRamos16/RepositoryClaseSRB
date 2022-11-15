using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : PlayerTrigger
{
	public Animator DoorAnimator;

	private bool doorIsOpen = true;

	public override void OnPlayerEnter(GameObject playerObject)
	{
		DoorAnimator.SetBool("OpenDoor", doorIsOpen);
		doorIsOpen = !doorIsOpen;
	}
}