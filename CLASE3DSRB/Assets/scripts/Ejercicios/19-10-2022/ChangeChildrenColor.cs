using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChildrenColor : MonoBehaviour
{
	// Start is called before the first frame update
	private MeshRenderer[] meshRenderers;

	private void Start()
	{
		meshRenderers = GetComponentsInChildren<MeshRenderer>();
		for (int i = 0; i < meshRenderers.Length; i++)
		{
			meshRenderers[i].material.color = Color.red;
		}
	}

	// Update is called once per frame
	private void Update()
	{
	}
}