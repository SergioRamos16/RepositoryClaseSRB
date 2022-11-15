using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSaveTest : MonoBehaviour
{
	private string nameKey = "playerName";

	public InputField myInputField;

	private void Start()
	{
		Debug.Log("el jugador se llama " + PlayerPrefs.GetString(nameKey));
	}

	public void SavePlayerName()
	{
		PlayerPrefs.SetString(nameKey, myInputField.textComponent.text);
	}

	// Update is called once per frame
	private void Update()
	{
	}
}