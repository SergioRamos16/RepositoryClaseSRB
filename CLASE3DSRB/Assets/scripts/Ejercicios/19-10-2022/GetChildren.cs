using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildren : MonoBehaviour
{
	public MeshRenderer mesh;

	public MeshRenderer[] meshes;

	// Start is called before the first frame update
	private void Start()
	{
		mesh = GetComponentInChildren<MeshRenderer>();

		meshes = GetComponentsInChildren<MeshRenderer>();
	}

	// Update is called once per frame
	private void Update()
	{
	}
}