using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : PlayerTrigger
{
	public int damageAmount = 1;

	public override void OnPlayerEnter(GameObject playerObject)
	{
		Health health = playerObject.GetComponent<Health>();
		health.TakeDamage(damageAmount);
	}
}