using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PlayerTrigger
{
	public int amountToGive = 1;

	public override void OnPlayerEnter(GameObject playerObject)
	{
		CoinCounter counter = playerObject.GetComponent<CoinCounter>();
		counter.GetCoins(amountToGive);
		gameObject.SetActive(false);
	}
}