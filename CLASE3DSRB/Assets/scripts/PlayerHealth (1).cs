using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PlayerHealth : Health
{
	public Image deathScreen;
	public float timeToFade = 3;

	public override void Die()
	{
		deathScreen.DOFade(1, timeToFade);
	}
}