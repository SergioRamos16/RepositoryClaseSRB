using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
	public int currentNumberOfCoins;

	public Text coinText;

	public void GetCoins(int cointAmount)
	{
		currentNumberOfCoins += cointAmount;

		if (coinText != null)
		{
			coinText.text = currentNumberOfCoins.ToString();
		}
		else
		{
			Debug.LogError("acuerdate de pasar el objeto en Unity");
		}
		Debug.Log("he recogido una moneda, tengo: " + currentNumberOfCoins + "monedas");
	}
}