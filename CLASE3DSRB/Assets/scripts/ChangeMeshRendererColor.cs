using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMeshRendererColor : MonoBehaviour
{
	public MeshRenderer meshRenderer;

	private void Start()
	{
		meshRenderer.material.color = Color.red;
	}
}