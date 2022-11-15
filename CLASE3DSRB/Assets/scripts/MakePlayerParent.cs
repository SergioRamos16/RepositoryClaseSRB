using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerParent : PlayerTrigger
{
	public Transform platform;

	private void Update()
	{
		transform.position = platform.position;
	}

	public override void OnPlayerEnter(GameObject playerObject)
	{
		playerObject.transform.parent = transform;
	}

	public override void OnPlayerExit(GameObject playerObject)
	{
		playerObject.transform.parent = null;
	}
}