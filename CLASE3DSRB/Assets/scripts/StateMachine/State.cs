using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class State : MonoBehaviour
{
    protected Transform player;
    protected string playerTag = "Player";
    protected NavMeshAgent agent;

    protected void Awake()
    {
        agent = GetComponentInParent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag(playerTag).transform;
    }

    public abstract State RunCurrentState();
}