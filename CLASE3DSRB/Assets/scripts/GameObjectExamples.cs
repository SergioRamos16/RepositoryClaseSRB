using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectExamples : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject myGameObject;

	public GameObject[] myGameObjects;

	private void Start()
	{
		//activamos o desactivamos un objeto
		myGameObject.SetActive(true);
		//activamos o desactivamos un  grupo de objetos
		for (int i = 0; i < myGameObjects.Length; i++)
		{
			myGameObjects[i].SetActive(false);
		}
	}

	// Update is called once per frame
	private void Update()
	{
	}
}