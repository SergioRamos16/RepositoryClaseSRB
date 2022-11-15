using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentTest : MonoBehaviour
{
	public NavMeshAgent myAgent;
	public Transform destination;

	// Start is called before the first frame update
	private void Start()
	{
		destination = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called once per frame
	private void Update()
	{
		myAgent.destination = destination.position;
	}
}