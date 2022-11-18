using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public float distanceToStartChasing = 3;
    public State chaseState;

    public override State RunCurrentState()
    {
        if (Vector3.Distance(transform.position, player.position) < distanceToStartChasing)
        {
            return chaseState;
        }
        else
        {
            agent.speed = 0;
            return this;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, distanceToStartChasing);
    }
}